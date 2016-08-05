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

namespace thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        private delegate void FlushClient();
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "00:00";

            th = new Thread(CrossThreadFlush);
            th.IsBackground = true;
            
        }
        private void CrossThreadFlush()
        {
            while(true)
            {
                Thread.Sleep(1000);
                ThreadFunction();
            }
        }
        int sum;
        int qian;
        int bai;
        int shi;
        int ge;
        private void ThreadFunction()
        {
            if(textBox1.InvokeRequired)
            {
                FlushClient fc = new FlushClient(ThreadFunction);
                this.Invoke(fc);
            }
            else
            {
                sum++;
                qian = sum / 1000;
                bai = sum % 1000 / 100;
                shi = sum % 100 / 10;
                ge = sum % 10;
                textBox1.Text = qian.ToString() + bai.ToString() + "." + shi.ToString() + ge.ToString();
            }
        }
       
        private void calculate()
        {
            while(true)
            {                
                sum++;
                qian = sum / 1000;
                bai = sum % 1000 / 100;
                shi = sum % 100 / 10;
                ge = sum % 10;
                textBox1.Text = qian.ToString() + bai.ToString() + "." + shi.ToString() + ge.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th.Start();
        }
    }
}
