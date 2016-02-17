using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    class zeComponent
    {
        public static Random rand = new Random();
        /** データの種類*/
        public enum TYPE
        {
            SHIKAKU,     // 四角形
            SANKAKU     // 三角形
        };
        /** 種類。処理を分けるのに利用する*/
         public static List<TYPE> type = new List<TYPE>();
        /** 底辺*/
         public static List<float> teihen = new List<float>();
        /** 高さ*/
         public static List<float> takasa = new List<float>();

         public static void tu()
         {
             for (int i = 0; i < 5; i++)
             {
                 // 四角形の作成
                 Shikaku.instantiateShikaku();
                 // 三角形の作成
                 Sankaku.instantiateSankaku();
             }
         }

        public static void hyo() {
            for (int i = 0; i < type.Count; i++)
            {
                if (i % 2 == 0) { Shikaku.shi(i); }
                else { Sankaku.san(i); }
            }
        }
    }
}
