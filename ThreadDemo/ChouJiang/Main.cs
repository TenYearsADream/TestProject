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

namespace ChouJiang
{
    public partial class Main : Form
    {
        private List<Label> lbList = new List<Label>();
        //private Thread threadStart;
        private bool isRuning = false;
        public Main()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }
       
        private void Main_Load(object sender, EventArgs e)
        {
            for(int i=0;i<6;i++)
            {
                Label lb = new Label();
                lb.Text = "0";
                lb.AutoSize = true;

                lb.Location = new Point(50*i+50,100);
                lbList.Add(lb);
                this.Controls.Add(lb);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isRuning = true;
            Thread thread = new Thread(() =>
            {
                Random r=new Random();
                while(isRuning)
                {
                    foreach(var item in lbList)
                    {
                        string str = r.Next(0, 10).ToString();
                        if(item.InvokeRequired)
                        {
                            item.Invoke(new Action<string>(s => { item.Text = s; }),str);
                        }
                        else
                        {
                            item.Text = str;
                        }
                    }
                    Thread.Sleep(200);
                }
            });
            thread.IsBackground = true;
            thread.Start();
            //threadStart = thread;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isRuning = false;
            //if(threadStart==null||(!threadStart.IsAlive))
            //{
            //    return;
            //}
            //threadStart.Abort();
        }
    }
}
