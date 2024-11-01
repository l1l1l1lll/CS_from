using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_from
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //1行目
            TestButton testButton = new TestButton(0,0,100,100);
            Controls.Add(testButton);

            TestButton testButton2= new TestButton(100,0,100,100);
            Controls.Add(testButton2);

            TestButton testButton3= new TestButton(200, 0, 100, 100);
            Controls.Add(testButton3);

            //二行目
            TestButton testButton4= new TestButton(0, 100, 100, 100);
            Controls.Add(testButton4);

            TestButton testButton5= new TestButton(100, 100, 100, 100);
            Controls.Add(testButton5);

            TestButton testButton6 = new TestButton(200, 100, 100, 100);
            Controls.Add(testButton6);

            //三行目
            TestButton testButton7= new TestButton(0, 200, 100, 100);
            Controls.Add(testButton7);

            TestButton testButton8= new TestButton(100, 200, 100, 100);
            Controls.Add(testButton8);

            TestButton testButton9= new TestButton(200, 200, 100, 100);
            Controls.Add(testButton9);

            //4行目
            TestButton testButton10= new TestButton(100, 300, 100, 100);
            Controls.Add(testButton10);


        }
    }
}
