using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;
using WMPLib;

namespace Grante
{
   
    public partial class mainPlayer : Page
    {

        ///グローバル変数置き場

        ///<summary>
        ///絶対パス。
        ///</summary>
        string absolutePath;
        ///<summary>
        ///stands for CurrentText。現在のシーンファイルの情報を読み込んでおく。
        ///</summary>
        string crntT;
        /// <summary>
        /// stands for CurrentReader。現在のシーンファイルの情報を読み込んでおく。
        /// </summary>
        StringReader crntR;
        ///<summary>
        ///タグが終了しているか
        ///</summary>
        bool isTagFinished = true;
        bool isStepFinished = true;
        /// <summary>
        /// シーンのタイトル。セーブデータに使用します。
        /// </summary>
        string sceneTitle;
        /// <summary>
        /// bgmを管理します。bgmは原則一つです。
        /// </summary>
        WindowsMediaPlayer bgmp = new WindowsMediaPlayer();
        /// <summary>
        /// 現在のキャラクターの数を定義します。
        /// </summary>
        int currentCharacters = 0;
        /// <summary>
        /// シーンファイルのカレントの行です。
        /// </summary>
        string line;
        /// <summary>
        /// テキスト表示の排他制御をするための論理型変数です。
        /// </summary>
        bool exc_text = false;
        int exci_text = 20;
        /// <summary>
        /// Tagクラスです。
        /// </summary>
        TagVariable tags = new TagVariable();
    }
}
