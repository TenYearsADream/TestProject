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

namespace xiancheng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread thread;
        private void Form1_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(activeChange));
            thread.IsBackground = true;
            thread.Start();
            
        }
        public void activeChange()  //无参
        {
            while(true)
            {
                if (this.InvokeRequired)
                {
                    Action<string> changetime = (str) => { label1.Text = str; };   
               
                    label1.Invoke(changetime, DateTime.Now.ToString());                                                                 
                }
                else
                {
                    label1.Text = DateTime.Now.ToString();
                }       
            }       
        }
    }
}
