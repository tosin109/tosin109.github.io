using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    class Sankaku
    {
        /** 三角形を作成*/
        public static void instantiateSankaku()
        {
            // 種類を三角形にする
            zeComponent.type.Add(zeComponent.TYPE.SANKAKU);
            // 底辺に1～10の乱数を求める
            zeComponent.teihen.Add(zeComponent.rand.Next(1, 11));
            // 高さに1～10の乱数を求める
            zeComponent.takasa.Add(zeComponent.rand.Next(1, 11));
        }

        public static void san(int i)
        {
            Form1.textBox1.AppendText("三角形：底辺" + zeComponent.teihen[i] + " 高さ" + zeComponent.takasa[i] + "=" + (zeComponent.teihen[i] * zeComponent.takasa[i] / 2f) + "\r\n");
        }
    }
}
