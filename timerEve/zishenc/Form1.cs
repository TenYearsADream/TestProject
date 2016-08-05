using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zishenc
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer timerEve;
        public Form1()
        {
            InitializeComponent();
            timerEve = new System.Windows.Forms.Timer();
            timerEve.Interval = 1000;
            timerEve.Tick += new EventHandler(timerEve_Tick);
            timerEve.Start();
        }
        void timerEve_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
