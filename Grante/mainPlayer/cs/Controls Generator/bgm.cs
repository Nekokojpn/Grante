using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Grante
{
   
    public partial class mainPlayer : Page
    {
        void bgm(string path,int volume)
        {
            bgmp.URL = path;
            bgmp.settings.autoStart = false;
            bgmp.settings.volume = volume;
            bgmp.controls.play();
        }
      
        

    }
}
