﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace CS_from
{
    class TestButton:Button
    {
        public TestButton(int X, int y)
        {
            //ClickイベントにOnClick関数を登録
            Click += OnClick;

            Text = "wawaaaw";

            Location = new Point(X,y);
        }

        public void OnClick(object sender,EventArgs s)
        {
            MessageBox.Show("ｓｓｓｓｊｆｊさｈｄ");
        }
    }
}
