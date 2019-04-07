using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grante
{
    /// <summary>
    /// Tagに使用する変数メンバ群クラスです。
    /// </summary>
    public class TagVariable
    {
        /// <summary>
        /// (Constructor)メンバ変数を初期化します。
        /// </summary>
        public TagVariable()
        {
            path = "";
            anim = "";
            duration = 0;
            wait = false;
        }
        /// <summary>
        /// src属性
        /// </summary>
        public string path;
        /// <summary>
        /// anim属性
        /// </summary>
        public string anim;
        /// <summary>
        /// duration属性
        /// </summary>
        public int duration;
        /// <summary>
        /// wait属性
        /// </summary>
        public bool wait;
    }
}
