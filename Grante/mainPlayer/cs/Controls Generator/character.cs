using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Grante
{

    public partial class mainPlayer : Page
    {

        //未完成
        void character_auto(string Path, string name, string OptionParam = "", int durationMillisec = 0, bool isWait = true)
        {
            a_method("character_auto();");
            Image img = createImg(Path);
            mainCanvas.Children.Add(img);
            Canvas.SetZIndex(img, -1);
            if (OptionParam == "FadeIn")
            {
                img.Opacity = 0;
                Storyboard st = doubleAnim(0, 1, durationMillisec, "Opacity", isWait);
                img.BeginStoryboard(st);
            }


            if (currentCharacters == 0)
            {
                currentCharacters++;
                a("currentCharacter:" + currentCharacters);
                a("charc wid:" + img.Width.ToString() + " hei:" + img.Height.ToString());
            }

        }
        void character_manual(string Path, string name, int xpos, int ypos, int decodeWidthSize = -1, int decodeHeightSize = -1, string OptionParam = "", int durationMillisec = 0, bool isWait = true)
        {
            a_method("character_manual();");

            Character chr = FindName(name) as Character;
            if (chr == null)
            {
                a_event(name+":作成。");
                chr = new Character(absolutePath+Path,name, decodeWidthSize, decodeHeightSize);
                RegisterName(name, chr);
                Image img = chr.getCharacter();
                img.Margin = new System.Windows.Thickness(xpos, ypos, 0, 0);
                mainCanvas.Children.Add(img);
                Canvas.SetZIndex(img, -1);
                if (OptionParam == "FadeIn")
                {
                    img.Opacity = 0;
                    Storyboard st = doubleAnim(0, 1, durationMillisec, "Opacity", isWait);
                    img.BeginStoryboard(st);
                }
                currentCharacters++;
                a("currentCharacter:" + currentCharacters);
            }
            else
            {
                a_event("Found Character:"+name);
                Image img = chr.getCharacter();
                UnregisterName(chr.name);
                img.Opacity = 0;
                Character chr_s = new Character(absolutePath + Path, name, decodeWidthSize, decodeHeightSize);
                Image img_s = chr_s.getCharacter();
                img_s.Margin = img.Margin;
                RegisterName(name, chr_s);
                mainCanvas.Children.Add(img_s);
                Canvas.SetZIndex(img, -1); 
                if (OptionParam == "FadeIn")
                {
                    img_s.Opacity = 0;
                    Storyboard st = doubleAnim(0, 1, durationMillisec, "Opacity", isWait);
                    img_s.BeginStoryboard(st);
                }
                else if(OptionParam == "CrossFade")
                {
                    Storyboard st = doubleAnim(1, 0, durationMillisec, "Opacity", false);      
                    img.Opacity = 0;
                    Storyboard st1 = doubleAnim(0, 1, durationMillisec, "Opacity", isWait);
                    
               
                    img.BeginStoryboard(st);
                    img_s.BeginStoryboard(st1);
                }
            }
            if(isWait==false)
            {
                jumper();
            }
            setzind();
        }

    }
}
