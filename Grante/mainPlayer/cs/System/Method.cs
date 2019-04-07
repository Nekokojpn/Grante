using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Grante
{
   
    public partial class mainPlayer : Page
    {

        void a(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(debtext + "\r\n");
        }
        void a_ly()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("*" + "\r\n");
        }
        void a_event(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(debtext + "\r\n");
        }
        void a_method(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(debtext + "\r\n");
        }
        void a_script(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(debtext + "\r\n");
        }
        void a_error(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(debtext + "\r\n");
        }
        /// <summary>
        /// 特定の文字列を取り出します。
        /// </summary>
        /// <param name="SrcStr">元のstring。</param>
        /// <param name="startIndexOfString">始めのサーチ文字列。</param>
        /// <param name="EndIndexOfString">終わりのサーチ文字列。</param>
        string str_Substring(string SrcStr, string startIndexOfString, string EndIndexOfString,bool spectialMode=false,string secondEndIndexOfString="")
        {
            try
            { 
                return SrcStr.Substring(SrcStr.IndexOf(startIndexOfString), SrcStr.IndexOf(EndIndexOfString) - SrcStr.IndexOf(startIndexOfString)).Replace(startIndexOfString, "");
            }
            catch(Exception ex)
            {
                if (spectialMode != true)
                {
                    a_error("str_Substringエラー(SrcStr:" + SrcStr + " startIndexOfString:" + startIndexOfString + " EndIndexOfString:" + EndIndexOfString + "):" + ex.ToString());

                    return "";
                }
                else
                {
                    a_script("処理モードの変換");
                    if (secondEndIndexOfString != "")
                    {
                        EndIndexOfString = ">";
                        try
                        {
                            return SrcStr.Substring(SrcStr.IndexOf(startIndexOfString), SrcStr.IndexOf(EndIndexOfString) - SrcStr.IndexOf(startIndexOfString)).Replace(startIndexOfString, "");
                        }
                        catch
                        {
                            a_error("シーンの終わりです。");
                            return "";
                        }
                    }
                    else
                    {
                        string one = "";  string two="";

                        EndIndexOfString = ">";
                        try
                        {
                             one =  SrcStr.Substring(SrcStr.IndexOf(startIndexOfString), SrcStr.IndexOf(EndIndexOfString) - SrcStr.IndexOf(startIndexOfString)).Replace(startIndexOfString, "");
                        }
                        catch
                        {
                            a_error("one:" + ex.ToString());
                            one = "";
                        }
                        try
                        {
                            EndIndexOfString = secondEndIndexOfString;
                             two = SrcStr.Substring(SrcStr.IndexOf(startIndexOfString), SrcStr.IndexOf(EndIndexOfString) - SrcStr.IndexOf(startIndexOfString)).Replace(startIndexOfString, "");
                        }
                        catch {
                            a_error("two:" + ex.ToString());
                            two = "";
                        }
                        
                        if(one.Length>two.Length)
                        {
                            return two;
                        }
                        else
                        {
                            return one;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 正規表現で文字列を抜き出します。=と"はいりません。
        /// </summary>
        /// <param name="srcStr">元のstring</param>
        /// <param name="startStr">始めの検索文字</param>
        /// <returns></returns>
        string getbyRegexTypeOfString(string srcStr,string startStr)
        {
            var ret = (Regex.Match(srcStr, startStr + "=\"(.+?)\"")).ToString().Replace(startStr + "=\"", "");
            ret = ret.Replace(ret.Substring(ret.Length - 1, 1),"");
            return ret;
        }
        string getbyRegexTypeOfSpaceOrDec(string srcStr, string startStr)
        {
            return (Regex.Match(srcStr, startStr + "=\"(.+?)>")).ToString();
        }
        string getbyRegexTypeOfTag(string srcStr)
        {
            var ret = (Regex.Match(srcStr, ">(.+?)<")).ToString().Replace("<", "");
            ret = ret.Replace(">", "");
            return ret;
        }
    }
}
