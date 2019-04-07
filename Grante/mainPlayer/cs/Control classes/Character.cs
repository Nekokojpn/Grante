using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Grante
{
    public class Character : debugg
    {
        internal Character(string fullpath, string scopename, int decodePixelWidth = -1, int decodePixelHeight = -1)
        {
            st = new Stopwatch();
            st.Start();
            chr = new Image();
            bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(fullpath);
            if (decodePixelWidth != -1 && decodePixelHeight != -1)
            {
                bmp.DecodePixelHeight = decodePixelHeight;
                bmp.DecodePixelWidth = decodePixelWidth;
            }
            bmp.EndInit();
            chr.Source = bmp;
            name = scopename;
            st.Stop();
            a_method("CharacterControl:Done(in " + st.Elapsed.TotalMilliseconds.ToString() + " ms)\r\nRegistedName="+scopename);
        }
        public enum CharacterMode
        {
            Auto,Manual
        }

        public Image getCharacter()
        {
            return chr;
        }
       
        
        private Image chr;
        private BitmapImage bmp;
        private Stopwatch st;
        public string name;
    }
}
