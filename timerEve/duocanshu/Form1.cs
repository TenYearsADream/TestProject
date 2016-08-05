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

namespace duocanshu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MyThread mt = new MyThread("3","4");


            Thread th = new Thread(new ThreadStart(mt.C));
            th.IsBackground = true;
            th.Start();           
        }
    }
}
