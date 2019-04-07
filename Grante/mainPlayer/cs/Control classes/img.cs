using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Grante
{
    internal class ImageControl:debugg
    {
        internal ImageControl(string fullpath,string scopename,int decodePixelWidth=-1,int decodePixelHeight=-1)
        {
            st = new Stopwatch();
            st.Start();
            image = new Image();
            bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(fullpath);
            if (decodePixelWidth != -1 && decodePixelHeight != -1)
            {
                bmp.DecodePixelHeight = decodePixelHeight;
                bmp.DecodePixelWidth = decodePixelWidth;
            }
            bmp.EndInit();
            image.Source = bmp;
         //   image.RegisterName(scopename, image);
            st.Stop();
            a_method("ImageControl:Done(in " + st.Elapsed.TotalMilliseconds.ToString() + " ms)");
        }
        private Image image;
        private BitmapImage bmp;
        private Stopwatch st;
        private string name;
        internal Image GetImage
        {
            get => image;
        }
        internal string Name
        {
            get => name;
            set=> image.RegisterName(value, image);
        }
    }
}
