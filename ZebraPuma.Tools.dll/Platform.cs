using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ZebraPuma.Tools
{
    public class Platform
    {
        [DllImport("libc")]
        static extern int uname(IntPtr buf);

        public bool IsMacOS()
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



    }
}
