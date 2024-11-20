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

        
        Form1 aaaform1;
        public TestButton(Form1 form1, int id,int X, int y,int width,int height)
        {
            string[] array = new string[10];
            array[0] = "a";
            array[1] = "b";
            array[2] = "c";
            array[3] = "d";
            array[4] = "e";
            array[5] = "f";
            array[6] = "g";
            array[7] = "h";
            array[8] = "i";
            array[9] = "j";
            aaaform1 = form1;

            //ClickイベントにOnClick関数を登録
            Click += OnClick;

            Text = array[id];
         
            Location = new Point(X,y);
            Size = new Size(width,height);
        }

        public void OnClick(object sender,EventArgs s)
        {
            aaaform1.LabelTextUpdate(Text);
        }
    }
}
