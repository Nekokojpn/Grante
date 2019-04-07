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

        /// <summary>
        /// 画像イメージを表示します。bitmapimage及びimageクラスでサポートされている形式で指定します。
        /// </summary>
        /// <param name="Path">イメージのパス。</param>
        /// <param name="OptionParam">Optionのパラメータ。例:FadeIn</param>
        /// <param name="durationMillisec">アニメーションのDuration。</param>
        /// <param name="isWait">アニメーションを待機してからJumperを呼び出すかの設定。</param>
        async void img(string Path, string OptionParam = "", int durationMillisec = 0,bool isWait=true)
        {
            try
            {
                ImageControl ic = new ImageControl(absolutePath + Path, System.IO.Path.GetFileNameWithoutExtension(Path) ,1280, 720);
                Image image = createImg(Path, 1280, 720);
                mainCanvas.Children.Add(image);
                Canvas.SetZIndex(image, -2);
                if(durationMillisec!=0&&OptionParam!="")
                {
                    if (OptionParam == "FadeIn")
                    {
                        a("img:FadeIn");
                        image.Opacity = 0;
                        Storyboard st = doubleAnim(0, 1, durationMillisec, "Opacity", isWait);
                        image.BeginStoryboard(st);
                    }
                }
                if(isWait!=true||OptionParam=="")
                {
                    jumper();
                }
                /*
                GC.Collect();
                a_script("ガベージコレクションが呼び出されました。");
                */
                setzind();
            }
            catch(Exception ex)
            {
                a_error("imgタグエラー:" + ex.ToString());
            }
        }

    }
}
