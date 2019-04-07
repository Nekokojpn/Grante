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


        async void t(string text, string name = "")
        {
            a_method("t();");
            exc_text = true;
            TextControl textControl = name != "" ? new TextControl(text, name) : new TextControl(text);
            if (textControl.Name != "")
            {
                chara_Tex.Text = textControl.Name;
            }
            else
            {

            }
            _mW.Children.Clear();
            foreach (OutlineFont.OutlineText t in textControl)
            {
                _mW.Children.Add(t);
                await Task.Delay(exci_text);
            }
            exci_text = 20;
            exc_text = false;

        }

    }
}
