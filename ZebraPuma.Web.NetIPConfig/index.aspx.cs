using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZebraPuma.Tools;
using System.Diagnostics;

namespace ZebraPuma.Web.NetIPConfig
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetPlatform();
            GetIpInfo();


        }

        private void GetIpInfo()
        {
            IPInfo IP = IPInfo.GetIPInfo();
            
            byte[] Octets = IP.IPAddress.GetAddressBytes();
            ip_a.Value = Octets[0].ToString();
            ip_b.Value = Octets[1].ToString();
            ip_c.Value = Octets[2].ToString();
            ip_d.Value = Octets[3].ToString();

            Octets = IP.SubNet.GetAddressBytes();
            net_a.Value = Octets[0].ToString();
            net_b.Value = Octets[1].ToString();
            net_c.Value = Octets[2].ToString();
            net_d.Value = Octets[3].ToString();

            Octets = IP.Gateway.GetAddressBytes();
            gw_a.Value = Octets[0].ToString();
            gw_b.Value = Octets[1].ToString();
            gw_c.Value = Octets[2].ToString();
            gw_d.Value = Octets[3].ToString();

            ip_info.Value = IP.Shell.Result;

        }


        private void GetPlatform()
        {

            NetIPConfigTitle.Text = string.Format("Net IP Config : {0}", OS.HostName);

            //pbMacOSX.Image = OS.Image(OSType.MacOSX);
            //pbLinux.Image = OS.Image(OSType.Linux);
            //pbWindows.Image = OS.Image(OSType.Windows);

            //this.Icon = OS.Icon();

        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            GetIpInfo();
        }


    }
}