using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threadhaha 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread newthread = new Thread(new ThreadStart(BackgroundProcess));
            newthread.Start();      
        }
        //定义一个代理
        private delegate void CrossThreadOperationControl();
        private void BackgroundProcess()
        {
            //将代理实例化为一个匿名代理
            CrossThreadOperationControl CrossDelete = delegate()
            {
                int i = 1;
                while(i<5)
                {
                    listBox1.Items.Add("Item" + i.ToString());
                    i++;
                }
                label1.Text = "我在新线程里访问这个label";
                listBox1.Items.Add(label1.Text);
            };
            listBox1.Invoke(CrossDelete);
        }
    }
}
