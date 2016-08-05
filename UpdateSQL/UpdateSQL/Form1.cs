using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 修改_Click(object sender, EventArgs e)
        {

        }

        private void 插入_Click(object sender, EventArgs e)
        {
            if(insertid())
            {

            }
        }

        public bool insertid()
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("id不能为空");
                return false;
            }               
            else
            {
                return true;
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox13.Text = "1";
        }
    }
}
