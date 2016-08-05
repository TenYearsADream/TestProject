using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuanzhi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form2 MyProperty { get; set; }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            MyProperty=frm;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyProperty.textBox1.Text = this.textBox1.Text;
            //frm.textBox1.Text = this.textBox1.Text;                                        
        }
    }
}
