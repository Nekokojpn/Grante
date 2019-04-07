using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Grante
{
    /// <summary>
    /// mainPlayer.xaml の相互作用ロジック
    /// </summary>
    public partial class mainPlayer : Page
    {
        public mainPlayer()
        {
            InitializeComponent();
        }

        private void playerPage_Loaded(object sender, RoutedEventArgs e)
        {
           // absolutePath = @"F:\MYFOLDER\ONEDRIVE\俺用フォルダ\Grante\Grante\bin\Debug\";
            absolutePath = @"D:\My FOLDER\ONEDRIVE\俺用フォルダ\Grante\Grante\bin\Debug\";
            set_SceneFile(@"test\scene\test.gr");
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            scene_Load();
        }

        private void uprCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            jumper();
        }

        private void msgCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            jumper();
        }
    }
}
