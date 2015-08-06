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
using System.Globalization;
using System.Threading;
using System.Net;



namespace ZebraPuma.NetIPConfig
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            GetPlatform();
            GetIpInfo();
            btRefresh.Select();

        }

        private void GetIpInfo()
        {
            var p = System.Environment.OSVersion.Platform.ToString();
            Debugger.Break();
        }

        
        private void GetPlatform()
        {

            String HostName = Dns.GetHostName();
            HostName = HostName.Split('.')[0].ToUpper();
            Text = string.Format("Net IP Config : {0}", HostName);


            //switch (Environment.OSVersion.Platform)
            //{
            //    case PlatformID.MacOSX:
            //        CurrentPlatform = Platform.MacOSX;
            //        break;
            //    case PlatformID.Unix:
            //        CurrentPlatform = (IsMacOS() ? Platform.MacOSX : Platform.Linux);
            //        break;
            //}

            //pbMacOSX.Image = LoadImage(Platform.MacOSX);
            //pbLinux.Image = LoadImage(Platform.Linux);
            //pbWindows.Image = LoadImage(Platform.Windows);

        }

     

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GetIpInfo();
        }

        //private Image LoadImage(Platform PlatformImage)
        //{

        //    Image img = Properties.Resources.Windows;
        //    switch (PlatformImage)
        //    {
        //        case Platform.Linux:
        //            img = Properties.Resources.Linux;
        //            break;
        //        case Platform.MacOSX:
        //            img = Properties.Resources.MacOSX;
        //            break;
        //    }

        //    if (CurrentPlatform != PlatformImage)
        //    {
        //        Bitmap bmp = new Bitmap(img.Width, img.Height);
        //        Graphics graphics = Graphics.FromImage(bmp);
        //        ColorMatrix colormatrix = new ColorMatrix();
        //        colormatrix.Matrix33 = .08F;
        //        ImageAttributes imgAttribute = new ImageAttributes();
        //        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
        //        graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
        //        graphics.Dispose();
        //        img = bmp;
        //    }
        //    else
        //    {
        //        Bitmap BitmapIcon = new Bitmap(img, new Size(32, 32));
        //        IntPtr Hicon = BitmapIcon.GetHicon();
        //        this.Icon = Icon.FromHandle(Hicon);

        //    };

        //    return img;

        //}

    }
}
