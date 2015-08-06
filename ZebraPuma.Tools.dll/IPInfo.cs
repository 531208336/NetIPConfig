using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;


namespace ZebraPuma.Tools
{
    public class IPInfo
    {
        private IPInfo()
        {
        }

        private IPInfo(String IPAddress, String SubNet, String Gateway)
        {
            this.IPAddress = FormatIPAddress(IPAddress);
            this.SubNet = FormatIPAddress(SubNet);
            this.Gateway = FormatIPAddress(Gateway);
        }

        public IPsource Source { get; set; }

        public String IPAddress { get; set; }
        public String SubNet { get; set; }
        public String Gateway { get; set; }

        public Shell Shell { get; set; }
        
        private string FormatIPAddress(String Address)
        {
            if (Address.StartsWith("0x"))
            {
                Address = Address.TrimStart("0x".ToCharArray());
                Address = String.Join(".", Split(Address, 2).Select(item => int.Parse(item, System.Globalization.NumberStyles.HexNumber)).ToArray());
            }
            var blocks = Address.Split('.');
            blocks = blocks.Select(item => item.Trim().PadLeft(3, ' ')).ToArray();
            return String.Join(".", blocks).ToString();
        }

        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        static public IPInfo GetIPInfo(IPsource source = IPsource.Shell)
        {
            switch (source)
            {
                case IPsource.Shell:
                    return GetIPInfoFromShell();
                case IPsource.FrameWork:
                    return GetIPInfoFromFrameWork();
                default:
                    return new IPInfo();
            }
        }

        static private IPInfo GetIPInfoFromShell()
        {
            // Get Ip Info from Shell

            IPInfo IP;

            Shell Shell = new Shell() { };

          
            switch (OS.Type)
            {
                case OSType.Windows:
                    Shell.Command = "ipconfig";
                    Shell.Pattern = @"IPv4.*: (?<ip>.*)\r\n.*: (?<net>.*)\r\n.*: (?<gw>.*)\r\n";
                    break;
                case OSType.Linux:
                    Shell.Command = "ifconfig";
                    Shell.Arguments = "eth0";
                    Shell.Pattern = @"inet\s(?<ip>.*)\snetmask\s(?<net>.*)\sbroadcast\s(?<gw>.*)";
                    break;
                case OSType.MacOSX:
                    Shell.Command = "ifconfig";
                    Shell.Arguments = "en0";
                    Shell.Pattern = @"inet\s(?<ip>.*)\snetmask\s(?<net>.*)\sbroadcast\s(?<gw>.*)";
                    break;
                default:
                    break;
            }

           if (Shell.Execute())
            {
                IP = new IPInfo(Shell.Values["ip"].Value, Shell.Values["net"].Value, Shell.Values["gw"].Value);
            }
            else
            {
                IP = new IPInfo();
            }
            IP.Source = IPsource.Shell;
            IP.Shell = Shell;
            return IP;



        }

        static private IPInfo GetIPInfoFromFrameWork()
        {
            // SIR :06-08-2015 : Cannot rely on this method because of some classes are not implemented in Mono like : IPv4Mask
            IPInfo IP;
            Boolean IsNetworkAvailable = NetworkInterface.GetIsNetworkAvailable();
            if (IsNetworkAvailable)
            {
                var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(i => i.NetworkInterfaceType == NetworkInterfaceType.Ethernet);
                var IPProp = Nic.GetIPProperties();
                var UnicastAddress = IPProp.UnicastAddresses.FirstOrDefault(ua => ua.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                IP = new IPInfo(UnicastAddress.Address.ToString(), UnicastAddress.IPv4Mask.ToString(), IPProp.GatewayAddresses.FirstOrDefault().Address.ToString());
            }
            else
            {
                IP = new IPInfo();
            }
            IP.Source = IPsource.FrameWork;
            return IP;
        }
    }

    public enum IPsource
    {
        Undefined,
        Shell,
        FrameWork
    }

}
