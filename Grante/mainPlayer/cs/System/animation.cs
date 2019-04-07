using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Grante
{
   
    public partial class mainPlayer : Page
    {
        Storyboard doubleAnim(double from,double to,int durationMillisec,string PropertyPathParameter,bool isWait=true)
        {
            Storyboard st = new Storyboard();
            if (isWait == true)
            {
                st.Completed += (sen, ee) =>
                {
                    jumper();
                };
            }
            DoubleAnimation da = new DoubleAnimation
            {
                Duration = TimeSpan.FromMilliseconds(durationMillisec),
                To = to,
                From = from

            };
            Storyboard.SetTargetProperty(da, new PropertyPath(PropertyPathParameter));
            st.Children.Add(da);
            return st;
        }
        Storyboard thicknessAnim(Thickness toMargin,int durationMillisec,string PropertyPathParameter, bool isWait=false)
        {
            Storyboard st = new Storyboard();
            if (isWait == true)
            {
                st.Completed += (sen, ee) =>
                {
                    jumper();
                };
            }
            ThicknessAnimation da = new ThicknessAnimation
            {
                Duration = TimeSpan.FromMilliseconds(durationMillisec),
                To = toMargin,
            

            };
            Storyboard.SetTargetProperty(da, new PropertyPath(PropertyPathParameter));
            st.Children.Add(da);
            return st;
        }
        Storyboard thicknessAnim(Thickness toMargin, int durationMillisec, string PropertyPathParameter,Thickness fromMargin, bool isWait = false)
        {
            Storyboard st = new Storyboard();
            if (isWait == true)
            {
                st.Completed += (sen, ee) =>
                {
                    jumper();
                };
            }
            ThicknessAnimation da = new ThicknessAnimation
            {
                Duration = TimeSpan.FromMilliseconds(durationMillisec),
                To = toMargin,
                From = fromMargin

            };
            Storyboard.SetTargetProperty(da, new PropertyPath(PropertyPathParameter));
            st.Children.Add(da);
            return st;
        }
    }
}
