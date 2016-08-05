using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
            btnwordwrap.Visible = false;
            btnsave.Visible = false;
            richTextBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string pwd = textBox2.Text;
            if(name=="admin"&&pwd=="admin")
            {
                MessageBox.Show("欢迎进入记事本");
                btnwordwrap.Visible = true;
                btnsave.Visible = true;
                richTextBox1.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button3.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void btnwordwrap_Click(object sender, EventArgs e)
        {
            if(btnwordwrap.Text=="自动换行")
            {
                richTextBox1.WordWrap = true;
                btnwordwrap.Text = "取消自动换行";
            }
            else if (btnwordwrap.Text == "取消自动换行")
            {
                richTextBox1.WordWrap = false;
                btnwordwrap.Text = "自动换行";
           }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //File方法一
            string str = richTextBox1.Text.Trim();
            File.WriteAllText(@"C:\Users\wangxf2\Desktop\newnew.txt", str);
            //FileStream方法二
            //using (FileStream fsWrite = new FileStream(@"C:\Users\XiaofengWang\Desktop\pic\newnew.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    string str = richTextBox1.Text.Trim();
            //    byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            MessageBox.Show("保存成功");
        }
    }
}
