using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace ZebraPuma.Tools
{
    public static class ImageHelper
    {
        public static Image GetOpacityImage(this Image img)
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
            return img;
        }

        public static Icon GetIcon(this Image img)
        {
            Bitmap BitmapIcon = new Bitmap(img, new Size(32, 32));
            IntPtr hIcon = BitmapIcon.GetHicon();
            return Icon.FromHandle(hIcon);
        }

        public static string ToSrcData(this Image img)
        {
           MemoryStream ms = new MemoryStream();
           img.Save(ms, ImageFormat.Png );
           byte[] imageBytes = ms.ToArray();
           return string.Format("data:image/png;base64,{0}", Convert.ToBase64String( imageBytes, Base64FormattingOptions.None ));
        }



    }
}
