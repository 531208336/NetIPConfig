﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;


namespace ZebraPuma.Tools
{
    public static class OS
    {
        [DllImport("libc")]
        static extern int uname(IntPtr buf);

        static bool IsOSChecked = false;

        static private OSType _OS { get; set; }

        public static OSType Type
        {
            get
            {
                if (!IsOSChecked)
                {
                    switch (Environment.OSVersion.Platform)
                    {
                        case System.PlatformID.Win32NT:
                            _OS = OSType.Windows;
                            break;
                        case System.PlatformID.MacOSX:
                            _OS = OSType.MacOSX;
                            break;
                        case System.PlatformID.Unix:
                            _OS = (IsMacOS() ? OSType.MacOSX : OSType.Linux);
                            break;
                    }
                    IsOSChecked = true;
                }
                return _OS;
            }
        }

        public static string HostName
        {
            get
            {
                String _HostName = Dns.GetHostName();
                _HostName = _HostName.Split('.')[0].ToUpper();
                return _HostName;
            }

        }

        private static bool IsMacOS()
        {
            {
                Boolean bReturn = false;
                if (Environment.OSVersion.Platform == System.PlatformID.Unix)
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

        public static Image Image()
        {
            return Image(Type);
        }


        public static Image Image(OSType OSImage)
        {

            Image img = Properties.Resources.Windows;
            switch (OSImage)
            {
                case OSType.Linux:
                    img = Properties.Resources.Linux;
                    break;
                case OSType.MacOSX:
                    img = Properties.Resources.MacOSX;
                    break;
            }

            if (OS.Type != OSImage)
            {
                Bitmap bmp = new Bitmap(img.Width, img.Height);
                Graphics graphics = Graphics.FromImage(bmp);
                ColorMatrix colormatrix = new ColorMatrix();
                colormatrix.Matrix33 = .08F;
                ImageAttributes imgAttribute = new ImageAttributes();
                imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
                graphics.Dispose();
                img = bmp;
            }

            return img;

        }

        public static Icon Icon()
        {
            return Icon(OS.Type);
        }

        public static Icon Icon(OSType OSImage)
        {
            
            Bitmap BitmapIcon = new Bitmap( Image( OSImage) , new Size(32, 32));
            IntPtr hIcon = BitmapIcon.GetHicon();
            return System.Drawing.Icon.FromHandle(hIcon);
        }

    }

    public enum OSType
    {
        Windows,
        Linux,
        MacOSX
    }



}
