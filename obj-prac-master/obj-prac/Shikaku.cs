using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    class Shikaku
    {
        /** 四角形を作成*/
        public static void instantiateShikaku()
        {
            // 種類を四角形にする
            zeComponent.type.Add(zeComponent.TYPE.SHIKAKU);
            // 底辺に1～10の乱数を求める
            zeComponent.teihen.Add(zeComponent.rand.Next(1, 11));
            // 高さに1～10の乱数を求める
            zeComponent.takasa.Add(zeComponent.rand.Next(1, 11));
        }

        public static void shi(int i)
        {
            Form1.textBox1.AppendText("四角形：底辺" + zeComponent.teihen[i] + " 高さ" + zeComponent.takasa[i] + "=" + (zeComponent.takasa[i] * zeComponent.teihen[i]) + "\r\n");
        }
    }
}
