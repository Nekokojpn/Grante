using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Grante
{
   
    public partial class mainPlayer : Page
    {
        
      async void wait(int millisec)
        {
            await Task.Delay(millisec);
            jumper();
        }

    }
}
