using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;




namespace ZebraPuma.NetIPConfig
{
    public partial class MainForm : Form
    {
        [DllImport("libc")]
        static extern int uname(IntPtr buf);

        private Platform CurrentPlatform;

        public MainForm()
        {
            InitializeComponent();
            GetPlatform();
            GetIpInfo();
            btRefresh.Select();

        }

        private void GetIpInfo()
        {
            String Command = "";
            String Arguments = "";
            String Pattern = "";
            txtInfo.Text = "";

            switch (CurrentPlatform)
            {
                case Platform.Windows:
                    Command = "ipconfig";
                    Pattern = @"IPv4.*: (?<ip>.*)\r\n.*: (?<net>.*)\r\n.*: (?<gw>.*)\r\n";
                    break;
                case Platform.Linux:
                    Command = "ifconfig";
                    Arguments = "eth0";
                    Pattern = @"inet\s(?<ip>.*)\snetmask\s(?<net>.*)\sbroadcast\s(?<gw>.*)";
                    break;
                case Platform.MacOSX:
                    Command = "ifconfig";
                    Arguments = "en0";
                    Pattern = @"inet\s(?<ip>.*)\snetmask\s(?<net>.*)\sbroadcast\s(?<gw>.*)";
                    break;
                default:
                    break;
            }

            Process pNet = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(Command);
            psi.Arguments = Arguments;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            pNet.StartInfo = psi;
            pNet.Start();
            txtInfo.Text += pNet.StandardOutput.ReadToEnd();
            Clipboard.Clear();
            Clipboard.SetText(txtInfo.Text);

            String Input = txtInfo.Text;
            Regex Ex = new Regex(Pattern);
            Match M = Ex.Match(Input);
            if (M.Success)
            {
                IPInfo Ip = new IPInfo(M.Groups["ip"].Value, M.Groups["net"].Value, M.Groups["gw"].Value);
                // IPInfo Ip = new IPInfo(M.Groups["ip"].Value,  "0xffffff00", M.Groups["gw"].Value );
                mtxtIPAddress.Text = Ip.IPAddress;
                mtxtSubNet.Text = Ip.SubNet;
                mtxtGateway.Text = Ip.Gateway;
            }
        }

        private void GetPlatform()
        {

                String HostName = Dns.GetHostName();
                HostName = HostName.Split('.')[0].ToUpper();
                Text = string.Format("Net IP Config : {0}", HostName);


            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                    CurrentPlatform = Platform.MacOSX;
                    break;
                case PlatformID.Unix:
                    CurrentPlatform = (IsMacOS() ? Platform.MacOSX : Platform.Linux);
                    break;
            }

            pbMacOSX.Image = LoadImage(Platform.MacOSX);
            pbLinux.Image = LoadImage(Platform.Linux);
            pbWindows.Image = LoadImage(Platform.Windows);

        }

        private enum Platform
        {
            Windows,
            Linux,
            MacOSX
        }

        private bool IsMacOS()
        {
            {
                Boolean bReturn = false;
                if (Environment.OSVersion.Platform == PlatformID.Unix)
                {

                    IntPtr buf = Marshal.AllocHGlobal(8192);
                    if (uname(buf) == 0)
                    {
                        string os = Marshal.PtrToStringAnsi(buf);
                        if (os == "Darwin")
                            bReturn = true;
                    }
                    Marshal.FreeHGlobal(buf);
                };
                return bReturn;
            }
        }

        private class IPInfo
        {
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

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetIpInfo();
        }

        private Image LoadImage(Platform PlatformImage)
        {

            Image img = Properties.Resources.Windows;
            switch (PlatformImage)
            {
                case Platform.Linux:
                    img = Properties.Resources.Linux;
                    break;
                case Platform.MacOSX:
                    img = Properties.Resources.MacOSX;
                    break;
            }

            if (CurrentPlatform != PlatformImage)
            {
                Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
                Graphics graphics = Graphics.FromImage(bmp);
                ColorMatrix colormatrix = new ColorMatrix();
                colormatrix.Matrix33 = .08F;
                ImageAttributes imgAttribute = new ImageAttributes();
                imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
                graphics.Dispose();   // Releasing all resource used by graphics
                img = bmp;
            }
            else
            {
                Bitmap BitmapIcon = new Bitmap(img, new Size(32, 32));
                IntPtr Hicon = BitmapIcon.GetHicon();
                this.Icon = Icon.FromHandle(Hicon);

            };

            return img;

        }

    }
}
