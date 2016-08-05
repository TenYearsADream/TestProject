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

namespace xiancheng2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void SetTextHandler(string result);
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread th1 = new Thread(new ThreadStart(CalNum));
            th1.IsBackground = true;//不设置的话会报错：无法访问已释放的对象
            th1.Start();            
        }
        private void CalNum()
        {
            while(true)
            {
                SetCalResult(DateTime.Now.ToString());
            }
            
        }
        private void SetCalResult(string result)
        {

            if (label1.InvokeRequired)
            {
                SetTextHandler set = new SetTextHandler(SetCalResult);//委托的方法参数应和SetCalResult一致  


                label1.Invoke(set, new object[] { result });//此方法第二参数用于传入方法,代替形参result 
            }
            else
            {
                label1.Text = result;
            }
            
         
        }
    }
}
