﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Net;
using ZebraPuma.Tools;

namespace ZebraPuma.Forms.NetIPConfig
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            GetPlatform();
            GetIpInfo();
        }

        private void GetIpInfo()
        {
            IPInfo IP = IPInfo.GetIPInfo();
            txtIP.Text = IP.IPAddress.ToString();
            txtNet.Text = IP.SubNet.ToString();
            txtGw.Text = IP.Gateway.ToString();
            txtInfo.Text = IP.Shell.Result ;
        }


        private void GetPlatform()
        {

            Text = string.Format("Net IP Config : {0}", OS.HostName);

            pbMacOSX.Image = OS.Image(OSType.MacOSX);
            pbLinux.Image = OS.Image(OSType.Linux);
            pbWindows.Image = OS.Image(OSType.Windows);

            this.Icon = OS.Icon();

        }



        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetIpInfo();
        }


    }
}
