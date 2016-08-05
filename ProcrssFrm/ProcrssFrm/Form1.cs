using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcrssFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var allProcess = Process.GetProcesses();
            foreach(var item in allProcess)
            {
                Console.WriteLine(item.ProcessName+" "+item.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process.Start("notepad", "2.html");
            Process.Start("iexplore.exe");
        }
    }
}
