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
            Page.EnableViewState = false;
            GetPlatform();
            GetIpInfo();


        }

        private void GetIpInfo()
        {
            IPInfo IP = IPInfo.GetIPInfo();
            
            byte[] Bytes = IP.IPAddress.GetAddressBytes();
            ip_a.Value = Bytes[0].ToString();
            ip_b.Value = Bytes[1].ToString();
            ip_c.Value = Bytes[2].ToString();
            ip_d.Value = Bytes[3].ToString();

            Bytes = IP.SubNet.GetAddressBytes();
            net_a.Value = Bytes[0].ToString();
            net_b.Value = Bytes[1].ToString();
            net_c.Value = Bytes[2].ToString();
            net_d.Value = Bytes[3].ToString();

            Bytes = IP.Gateway.GetAddressBytes();
            gw_a.Value = Bytes[0].ToString();
            gw_b.Value = Bytes[1].ToString();
            gw_c.Value = Bytes[2].ToString();
            gw_d.Value = Bytes[3].ToString();

            //ip_info.Value = IP.Shell.Result;

            ip_info.InnerText = IP.Shell.Result;

        }


        private void GetPlatform()
        {

            NetIPConfigTitle.Text = string.Format("Net IP Config : {0}", OS.HostName);

            // data:image/jpeg;base64

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