using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;
using System.Text.RegularExpressions;
using WMPLib;
using System.Windows.Media.Animation;

namespace Grante
{

    public partial class mainPlayer : Page
    {
        ///シーンファイルを読んでいくメイン処理部です。
        void set_SceneFile(string Path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    crntT = sr.ReadToEnd();
                }
                crntR = new StringReader(crntT);
                a_event(Path + "が読み込まれました。");
            }
            catch(Exception ex)
            {
                a_error("set_SceneFileメソッドエラー:"+ex.ToString());
            }
            scene_Load();
        }
        #region jumper
        /// <summary>
        /// 再帰回避メソッド
        /// </summary>
        void jumper()
        {
            scene_Load();
        }
        #endregion
        void scene_Load()
        {
            {
                if (exc_text == true)
                {
                    exci_text = 0; //textの待機時間を0に設定して全文を一瞬表示する。
                    return;   //処理が行われないようにreturnする
                }
            }
            line = crntR.ReadLine();
            a_method("scene_Load(); line:" + line);
            _mW.Children.Clear();
            chara_Tex.Text = "";
            //タグ判定,タグ終了判定=trueになるまでそのタグで処理を続行する


            a("line:" + line);
            if (line == null)
            {
                a_error("EOFが検知されました");
                return;
            }
            if (line.IndexOf("//") > -1)
            {
                jumper();
                return;
            }
            if (line.IndexOf("<setting") > -1)
            {
                //NOMULTILINE
                sceneTitle = getbyRegexTypeOfString(line, "title");
                a("シーンタイトル:" + sceneTitle);
                jumper();
            }
            #region 開始タグ
            else if (line.IndexOf("<&;") > -1)
            {
                isStepFinished = false;
                jumper();
            }
            else if (line.IndexOf("</&;") > -1)
            {
                isStepFinished = true;
                a("クリック待ち");
                ///くりっくまちいいいいいい
            }
            #endregion
            #region imgタグ
            else if (line.IndexOf("<img") > -1)
            {
                tags.path = getbyRegexTypeOfString(line, "src");
                a("Path:" + tags.path);

                tags.anim = "";
                if (line.IndexOf("anim=") > -1)
                {
                    tags.anim = getbyRegexTypeOfString(line, "anim");
                }
                tags.duration = 0;
                if (line.IndexOf("duration") > -1)
                {
                    tags.duration = int.Parse(getbyRegexTypeOfString(line, "duration"));
                }
                if (line.IndexOf("wait") > -1)
                {
                    if (getbyRegexTypeOfString(line, "wait") == "true")
                    {
                        tags.wait = true;
                    }
                    else
                    {
                        tags.wait = false;
                    }
                }
                img(tags.path, tags.anim, tags.duration, tags.wait);
                //jumper();  imgメソッド内
            }
            #endregion
            #region characterタグ
            else if (line.IndexOf("<character") > -1)
            {
                string path = getbyRegexTypeOfString(line, "src");
                a("Path:" + path);

                string name = "";
                if (line.IndexOf("name") > -1)
                {
                    name = getbyRegexTypeOfString(line, "name");
                }
                string option = "";
                if (line.IndexOf("option=") > -1)
                {
                    option = getbyRegexTypeOfString(line, "option");
                }
                int duration = 0;
                if (line.IndexOf("duration") > -1)
                {
                    duration = int.Parse(getbyRegexTypeOfString(line, "duration"));
                }
                bool isWait = false;
                if (line.IndexOf("wait") > -1)
                {
                    if (getbyRegexTypeOfString(line, "wait") == "true")
                    {
                        isWait = true;
                    }
                    else
                    {
                        isWait = false;
                    }
                }
                int xpos = 0;
                if (line.IndexOf("xpos") > -1)
                {
                    xpos = int.Parse(getbyRegexTypeOfString(line, "xpos"));
                }
                int ypos = 0;
                if (line.IndexOf("ypos") > -1)
                {
                    ypos = int.Parse(getbyRegexTypeOfString(line, "ypos"));
                }
                character_manual(path, name, xpos, ypos, -1, -1, option, duration, isWait);
            }
            #endregion
            #region tadタグ
            else if (line.IndexOf("<tad") > -1)
            {
                string tad = getbyRegexTypeOfString(line, "duration");
                a(tad);

                wait(int.Parse(tad));

                //jumper();   waitメソッド内
            }
            #endregion
            #region tタグ
            else if (line.IndexOf("<t") > -1)
            {
                string name = "";
                if (line.IndexOf("name") > -1)
                {
                    name = getbyRegexTypeOfString(line, "name");
                }
                string tex = getbyRegexTypeOfTag(line);
                t(tex, name);
                a("tex:" + tex + " name:" + name);
                a("クリック待ち");
            }
            #endregion
            #region bgmタグ
            else if (line.IndexOf("<bgm") > -1)
            {
                string path = getbyRegexTypeOfString(line, "src");
                int volume = int.Parse(getbyRegexTypeOfString(line, "volume"));
                bgm(path, volume);
                a("bgm:" + path + " vol:" + volume);
                jumper();
            }
            #endregion
            else if (line.IndexOf("<animation") > -1)
            {
                string targetelementname = getbyRegexTypeOfString(line, "target");
                //ここからだよーん
            }
        }
    }
}
