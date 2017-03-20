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
                    image.Compare(images);
                }
            }
        }

        public void TakeScreenshot(string savePath)
        {
            using (MagickImage screen = new MagickImage("screenshot:"))
            {
                screen.Write(savePath);
            }
        }

        public void Check(string path1, string path2)
        {
            var diffImagePath = @"D:\Compare Test\imageDiff.jpg";

            using (MagickImage image1 = new MagickImage(path1))
            using (MagickImage image2 = new MagickImage(path2))
            using (MagickImage diffImage = new MagickImage())
            {
                image1.Compare(image2, ErrorMetric.Absolute, diffImage);
                diffImage.Write(diffImagePath);
            }
        }
    }
}
