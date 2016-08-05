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

namespace ThreadTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calNum()
        {
            while(true)
            {
                SetCalResult(Convert.ToString(DateTime.Now));
            }
        }
        public delegate void SetTextHandler(string result);
        private void SetCalResult(string result)
        {
            
                if (label1.InvokeRequired)
                {
                    SetTextHandler set = new SetTextHandler(SetCalResult);
                    label1.Invoke(set, new object[] { result });
                }
                else
                {
                    label1.Text = result;
                }
                  
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Thread th1 = new Thread(new ThreadStart(calNum));
            th1.IsBackground = true;
            th1.Start();






            ////using(BackgroundWorker bw=new BackgroundWorker())
            ////{
            ////    bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            ////    bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            ////    while(true)
            ////    {
            ////        bw.RunWorkerAsync(DateTime.Now);
            ////    }
               
            ////}               
            //Thread thread = new Thread(new ParameterizedThreadStart(showtime));
            //thread.IsBackground = true;
            //thread.Start();
        }     
        ////void bw_DoWork(object sender, DoWorkEventArgs e)
        ////{
        ////    Thread.Sleep(500);
         
        ////    //while(true)
        ////    //{
        ////        e.Result = e.Argument + "工作线程完成";
        ////   // }
            
                  
        ////}

        ////void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        ////{
           
           
        ////        label1.Text = e.Result.ToString();
                   
        ////}
        //private void showtime(object str)
        //{
        //    while(true)
        //    {
        //        if (label1.InvokeRequired)
        //        {
        //            Action<string> actionDelete = (string x) => { this.label1.Text = x; };
        //            this.label1.Invoke(actionDelete, Convert.ToString(DateTime.Now));
        //        }
        //        else
        //        {
        //            this.label1.Text = Convert.ToString(DateTime.Now);
        //        }
        //    }         
        //}
    }
}
