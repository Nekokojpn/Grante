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
       void setzind()
        {
            Canvas.SetZIndex(uprCanvas, 1);
            Canvas.SetZIndex(msgCanvas, 1);
        }
    }
}
