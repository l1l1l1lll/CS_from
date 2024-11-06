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
        
        public TestButton(int id,int X, int y,int width,int height)
        {
            //ClickイベントにOnClick関数を登録
            Click += OnClick;
         
            Text = id.ToString();
         
            Location = new Point(X,y);
            Size = new Size(width,height);
        }

        public void OnClick(object sender,EventArgs s)
        {
            MessageBox.Show(Text);
        }
    }
}
