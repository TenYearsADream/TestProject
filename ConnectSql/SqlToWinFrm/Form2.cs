using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlToWinFrm
{
    public delegate void ClickDelegateHander1(string message1); //声明一个委托
    public delegate void ClickDelegateHander2(string message2); //声明一个委托
    public delegate void ClickDelegateHander3(string message3); //声明一个委托
    public delegate void ClickDelegateHander4(string message4); //声明一个委托
    public partial class Form2 : Form
    {
        public event ClickDelegateHander1 changemessage1;
        public event ClickDelegateHander2 changemessage2;
        public event ClickDelegateHander3 changemessage3;
        public event ClickDelegateHander4 changemessage4;
        public Form2()
        {
            InitializeComponent();
        }

        private void Transform_Click(object sender, EventArgs e)
        {
            changemessage1(textBox1.Text);
            changemessage2(textBox2.Text);
            changemessage3(textBox3.Text);
            changemessage4(textBox4.Text);
        }    
    }
}
