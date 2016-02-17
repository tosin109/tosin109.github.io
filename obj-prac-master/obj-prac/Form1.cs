using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace obj_prac
{
    public partial class Form1 : Form
    {
        /** 初期化*/
        public Form1()
        {
            InitializeComponent();

            zeComponent.tu();
        }

        /** ボタンを押したら種類に応じて面積を求めてTextBox1に表示する*/
        private void button1_Click(object sender, EventArgs e)
        {
            zeComponent.hyo();
        }
    }
}
