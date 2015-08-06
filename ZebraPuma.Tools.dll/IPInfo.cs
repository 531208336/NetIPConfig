using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Net.NetworkInformation;


namespace ZebraPuma.Tools
{


    public class IPInfo
    {
        public IPInfo() { }

        public IPInfo(String IPAddress, String SubNet, String Gateway)
        {
            this.IPAddress = FormatIPAddress(IPAddress);
            this.SubNet = FormatIPAddress(SubNet);
            this.Gateway = FormatIPAddress(Gateway);
        }



        public String IPAddress { get; set; }
        public String SubNet { get; set; }
        public String Gateway { get; set; }

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

        private IPInfo  GetIPInfoFromShell()
        {
            // Get Ip Info from Shell

            IPInfo IP = new IPInfo();

            String Command = "";
            String Arguments = "";
            String Pattern = "";
            String Result = "";

            //switch (CurrentPlatform)
            //{
            //    case Platform.Windows:
            //        Command = "ipconfig";
            //        Pattern = @"IPv4.*: (?<ip>.*)\r\n.*: (?<net>.*)\r\n.*: (?<gw>.*)\r\n";
            //        break;
            //    case Platform.Linux:
            //        Command = "ifconfig";
            //        Arguments = "eth0";
            //        Pattern = @"inet\s(?<ip>.*)\snetmask\s(?<net>.*)\sbroadcast\s(?<gw>.*)";
            //        break;
            //    case Platform.MacOSX:
            //        Command = "ifconfig";
            //        Arguments = "en0";
            //        Pattern = @"inet\s(?<ip>.*)\snetmask\s(?<net>.*)\sbroadcast\s(?<gw>.*)";
            //        break;
            //    default:
            //        break;
            //}

            Process pNet = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(Command);
            psi.Arguments = Arguments;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            pNet.StartInfo = psi;
            pNet.Start();
            Result = pNet.StandardOutput.ReadToEnd();

            String Input = Result;
            Regex Ex = new Regex(Pattern);
            Match M = Ex.Match(Input);
            if (M.Success)
            {
                IP = new IPInfo();
            }
            return IP;

        }

        private void GetIPInfoFromFrameWork()
        {
            // Cannot rely on this method because of some classes are not implemented in Mono like : IPv4Mask
            Boolean IsNetworkAvailable = NetworkInterface.GetIsNetworkAvailable();
            if (IsNetworkAvailable)
            {
                var Nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(i => i.NetworkInterfaceType == NetworkInterfaceType.Ethernet);
                var IPProp = Nic.GetIPProperties();
                var UnicastAddress = IPProp.UnicastAddresses.FirstOrDefault(ua => ua.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                var Ip = UnicastAddress.Address.ToString();
                var Sub = UnicastAddress.IPv4Mask.ToString();
                var Gw = IPProp.GatewayAddresses.FirstOrDefault().Address.ToString();
            }




        }

        private enum Platform
        {
            Windows,
            Linux,
            MacOSX
        }


    }
}
