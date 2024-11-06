using System;
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
        Form1 _form1;
        public TestButton(Form1 form1, int id,int X, int y,int width,int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            Click += OnClick;
         
            Text = id.ToString();
         
            Location = new Point(X,y);
            Size = new Size(width,height);
        }

        public void OnClick(object sender,EventArgs s)
        {
            _form1.LabelTextUpdate(Text);
        }
    }
}
