using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace processBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 10;
        }
        private delegate void SetPos(int ipos);
        private void SetTextMessage(int ipos)
        {
            if(this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMessage);
                this.Invoke(setpos,ipos);
            }
            else
            {
                this.Text = ipos.ToString() + "/100";
                this.progressBar1.Value = Convert.ToInt32(ipos);           
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread fThread = new Thread(new ThreadStart(SleepT));
            fThread.IsBackground = true;
            fThread.Start();
        }
        private void SleepT()
        {
            for(int i=0;i<500;i++)
            {
                System.Threading.Thread.Sleep(100);
                SetTextMessage(100 * i / 500);
            }
        }
    }
}
