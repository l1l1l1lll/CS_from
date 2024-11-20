using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//
namespace CS_from
{
    public partial class Form1 : Form
    {
        Testlllabel _testLabel;
        TestTextBox _textBox;
        TestTextBox inputtextbox;

  
        public Form1()
        {
            InitializeComponent();
       

            for (int i = 0; i<10; i++)
            { 
                 TestButton testButton11 = new TestButton(this,i,(i%4)*100, (i/4)*100, 100, 100);
               Controls.Add(testButton11);

            }

            Swapbutton sbutton = new Swapbutton(this,500,500,300,300,300);
            Controls.Add(sbutton);





            _testLabel =
                new Testlllabel("ボタンをおしてね", 300, 300, 500,500);
        Controls.Add(_testLabel);

           _textBox =
    new TestTextBox("a", 10, 300, 400, 500);

            Controls.Add(_textBox);


            inputtextbox =
  new TestTextBox("REPLACE", 10, 330, 400, 500);

            Controls.Add(inputtextbox);


        }

        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }


    }
}
