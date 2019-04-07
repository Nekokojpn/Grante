using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Grante
{
   
    public partial class mainPlayer : Page
    {
        Image createImg(string Path, int width=-1,int height=-1)
        {
            Image image = new Image();
            if (width != -1 && height != -1)
            {
                image.Width = width;
                image.Height = height;
            }
            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            a(absolutePath + Path);
            bmp.UriSource = new Uri(absolutePath + Path);
            if (width != -1 && height != -1)
            {
                bmp.DecodePixelHeight = height;
                bmp.DecodePixelWidth = width;
            }
            bmp.EndInit();
            image.Source = bmp;
            return image;
        }
        void loadImg(Image image,string Path, int width = -1, int height = -1)
        {
            if (width != -1 && height != -1)
            {
                image.Width = width;
                image.Height = height;
            }
            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            a(absolutePath + Path);
            bmp.UriSource = new Uri(absolutePath + Path);
            if (width != -1 && height != -1)
            {
                bmp.DecodePixelHeight = height;
                bmp.DecodePixelWidth = width;
            }
            bmp.EndInit();
            image.Source = bmp;
          
        }
    }
}
