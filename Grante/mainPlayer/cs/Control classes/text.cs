using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using OutlineFont;
namespace Grante
{
    internal class TextControl:debugg
    {
        /// <summary>
        /// このコンストラクタはイニシャライズされず、列挙できません。
        /// </summary>
        internal TextControl()
        {
            base.a_method("TextControl:コンストラクタ１初期化中...");
            text = "";
            name = "";
            font = new FontFamily("Yu Gothic");
            fontsize = 24;
            color = new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));
        }
        /// <summary>
        /// このコンストラクタはイニシャライズされ、列挙可能です。
        /// </summary>
        internal TextControl(string in_text)
        {
            base.a_method("TextControl:コンストラクタ２初期化中...");
            text = in_text;
            name = "";
            font = new FontFamily("Yu Gothic");
            fontsize = 24;
            color = new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));
            initializeText();
        }
        /// <summary>
        /// このコンストラクタはイニシャライズされ、列挙可能です。
        /// </summary>
        internal TextControl(string in_text,string in_name)
        {
            base.a_method("TextControl:コンストラクタ３初期化中...");
            text = in_text;
            name = in_name;
            font = new FontFamily("Yu Gothic");
            fontsize = 24;
            color = new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));
            initializeText();
        }
        private string text;
        private string name;
        private int fontsize;
        private FontFamily font;
        private OutlineText[] tbs;
        private SolidColorBrush color;
        /// <summary>
        /// 表示するテキストを設定します。
        /// このセッターでコレクションTextBlockが確定されます。
        /// </summary>
        internal string Text
        {
            get => text;
            set
            {
                if (value.Length != 0)
                {
                    text = value;
                    initializeText();
                }
            }
        }
        internal int textLength
        {
            get => text.Length;
        }
        internal string Name
        {
            get => name;
            set => name = value;
        }
        internal FontFamily Font
        {
            set => font = value;
        }
        internal int FontSize
        {
            get => fontsize;
            set => fontsize = value;
        }
        internal SolidColorBrush SetColor
        {
            set => color = value;
        }
        internal void initializeText()
        {
            Stopwatch st = new Stopwatch();
            st.Start();
           
            
            tbs = new OutlineText[text.Length];
            //初期化処理
            int i = 0;
            for(int j = 0; j<text.Length;j++)
            {
                tbs[j] = new OutlineText();
            }
            foreach (OutlineText tb in tbs)
            {
                tb.Text = text.Substring(i++, 1);
                tb.FontFamily = font;
                tb.FontSize = fontsize;
                tb.Fill = color;
                tb.Stroke = color;//new SolidColorBrush(Color.FromRgb(0,0,0));
                tb.StrokeThickness = 1;
            }
            st.Stop();
            base.a_method("TextControl:Done(in "+st.Elapsed.TotalMilliseconds.ToString()+" ms)");
        }
        public IEnumerator GetEnumerator()
        {
            foreach(OutlineText tb in tbs)
            {
                yield return tb;
            }
        }
    }
}
