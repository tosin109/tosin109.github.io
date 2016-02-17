using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1310
{
    public partial class Form1 : Form
    {
        public Random ran = new Random();

        enum Type
        {
            shi, san
        };

        List<Type> type = new List<Type>();
        List<float> mi = new List<float>();
        List<float> ta = new List<float>();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                inshi();
                insan();
            }
        }

        void inshi()
        {
            type.Add(Type.shi);
            mi.Add(ran.Next(1, 11));
            ta.Add(ran.Next(1, 11));
        }

        void insan()
        {
            type.Add(Type.san);
            mi.Add(ran.Next(1, 11));
            ta.Add(ran.Next(1, 11));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < type.Count; i++)
            {
                textBox1.AppendText(calc(i) + "\r\n");
            }
        }
        string calc(int nu)
        {
            switch (type[nu])
            {
                case Type.shi:
                    return "四角形 : 底辺" + mi[nu] + "高さ" + ta[nu] + " = " + (mi[nu] * ta[nu]);
                case Type.san:
                    return "三角形 : 底辺" + mi[nu] + "高さ" + ta[nu] + " = " + (mi[nu] * ta[nu] / 2f);
            }

            return "";
        }
    }
}
