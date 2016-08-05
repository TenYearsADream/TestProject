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

namespace paramWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                  
        }     
        private void Form1_Load(object sender, EventArgs e)
        {           
            
        }
        private void Calculate(object o)  //必须写成object类型
        {
            if (textBox1.InvokeRequired)
            {
                Action<string> sum = (s) => { textBox1.Text = s; };
                textBox1.Invoke(sum, Convert.ToString(Convert.ToInt32(o) * 8));
            }
            else
            {
                textBox1.Text = Convert.ToString(o);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Calculate);
            Thread thread = new Thread(threadStart);
            thread.Start(5); 
        }      
    }
}
