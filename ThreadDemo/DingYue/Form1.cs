using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DingYue
{
    public partial class Form1 : Form
    {
        public List<IChild> MyChild { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            this.MyChild = new List<IChild>();
            this.MyChild.Add(child);
            child.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //遍历那个所有关注消息变化的子窗体
            if (MyChild == null)
            {
                return;
            }


            foreach (var item in MyChild)
            {
                item.SetText(this.textBox1.Text);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
