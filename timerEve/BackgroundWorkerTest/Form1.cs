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

namespace BackgroundWorkerTest
{
    public partial class Form1 : Form
    {
        private BackgroundWorker m_BackgroundWorker;
        public Form1()
        {
            InitializeComponent();
 
            m_BackgroundWorker=new BackgroundWorker();

            m_BackgroundWorker.WorkerReportsProgress = true;

            m_BackgroundWorker.WorkerSupportsCancellation = true;

            m_BackgroundWorker.DoWork+=new DoWorkEventHandler(DoWork);

            m_BackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgress);

            m_BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompletedWork);

            m_BackgroundWorker.RunWorkerAsync(this);
        }

        void CompletedWork(object sender, RunWorkerCompletedEventArgs e)
        {            
            if (e.Error != null)
            {
                MessageBox.Show("Error");
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Canceled");
            }
            else
            {
                MessageBox.Show("Completed");
            }
        }

        void UpdateProgress(object sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage;

            label1.Text = string.Format("{0}", progress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void DoWork(object sender,DoWorkEventArgs e)
        {            
            BackgroundWorker bw = sender as BackgroundWorker;
            Form1 frm1 = e.Argument as Form1;
            int i = 0;
            while(i<10)
            {
                if(bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                bw.ReportProgress(i++);
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_BackgroundWorker.CancelAsync();
        }
    }
}
