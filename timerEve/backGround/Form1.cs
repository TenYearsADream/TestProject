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

namespace backGround
{
    public partial class Form1 : Form
    {
        private BackgroundWorker m_BackgroundWorker;
        public Form1()
        {
            InitializeComponent();

          

            m_BackgroundWorker = new BackgroundWorker();

            m_BackgroundWorker.WorkerReportsProgress = true;

            m_BackgroundWorker.DoWork += new DoWorkEventHandler(DoWork);

            m_BackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgress);

            m_BackgroundWorker.RunWorkerAsync(this);
        }

        void UpdateProgress(object sender, ProgressChangedEventArgs e)
        {
            string progress = e.UserState.ToString();

            label1.Text = string.Format("{0}", progress);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
               
            while (true)
            {            
                bw.ReportProgress(0,DateTime.Now);
                Thread.Sleep(1000);
            }
        }

    }
}
