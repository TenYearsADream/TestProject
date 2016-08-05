using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerEve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timeCount.Interval = 1000;
            timeCount.Tick += timeCount_Tick;               
        }

        void timeCount_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeCount.Enabled = true;
            //timeCount.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeCount.Stop();
        }
    }
}
