using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeiTuo
{
    public partial class Form1 : Form
    {
        public Action<string> AfterMsgSend { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            AfterMsgSend += frm.SetText;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(AfterMsgSend==null)
            {
                return;
            }
            AfterMsgSend(this.textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
