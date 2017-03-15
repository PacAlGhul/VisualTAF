using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;

namespace VisualTAF
{
    public class ImageWorker
    {
        public void FindDifference(string path1, string path2)
        {
            MagickImageCollection colection = new MagickImageCollection();
            using (MagickImage image = new MagickImage(path1))
            {
                using (MagickImage images = new MagickImage(path2))
                {
                    MagickFormat asd = MagickFormat.Screenshot;
                }
            }
        }

        public void TakeScreenshot(string savePath)
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height,
                PixelFormat.Format32bppRgb);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
                    0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            }
            using (MagickImage screen = new MagickImage(bmp))
            {
                screen.Write(savePath);
            }
        }
    }
}
