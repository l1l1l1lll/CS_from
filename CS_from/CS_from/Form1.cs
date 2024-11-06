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
          
           
            for (int i = 0; i<10; i++)
            { 
                 TestButton testButton11 = new TestButton(i,(i%3)*100, (i/3)*100, 100, 100);
                Controls.Add(testButton11);

            }

            TestLabel testLabel =
                new TestLabel("llll", 300, 300, 500,500);
        Controls.Add(testLabel);
        }
    }
}
