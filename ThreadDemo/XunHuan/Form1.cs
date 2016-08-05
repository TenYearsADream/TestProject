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

namespace XunHuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //真正的项目中不能使用
            //Control.CheckForIllegalCrossThreadCalls = false;
            //真正处理夸线程调用
        }

        private void btmLoop_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                if(btmLoop.InvokeRequired)//如果是别的线程控制的此空件true
                {
                    //找到创建这个控件的线程执行
                    btmLoop.Invoke(new Action<string>(s => { this.btmLoop.Text = s; }), DateTime.Now.ToString());
                }
                else
                {
                    this.btmLoop.Text = DateTime.Now.ToString();
                }
                   
                    
                
                while (true)
                {
                    Console.WriteLine(DateTime.Now.ToString());
                }
            });
            thread.IsBackground = true;
            thread.Start();
            
        }
    }
}
