using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VisualTAF
{
    [TestFixture]
    public class TryUseClick
    {
        [Test]
        public void TestMethod()
        {
            string path1 = @"C:\Users\Yauheni_Dzima\Source\Repos\VisualTAF\VisualTAF\VisualTAF\bin\Debug\Desktop.png";
            string path2 = @"C:\Users\Yauheni_Dzima\Source\Repos\VisualTAF\VisualTAF\VisualTAF\bin\Debug\WinButton.png";
            string path3 = @"C:\Users\Yauheni_Dzima\Source\Repos\VisualTAF\VisualTAF\VisualTAF\bin\Debug\euro.png";
            ImageWorker image = new ImageWorker();
            image.TakeScreenshot(path1);
            Console.WriteLine(image.FindDifference(path1, path2));
            image.FindSubImage(path1,path2);
            //HelpMethods.Click(1850,0);
            HelpMethods.ForDebug();
        }
    }
}
