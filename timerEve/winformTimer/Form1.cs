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

namespace winformTimer
{
    public partial class Form1 : Form
    {
        //不精确   
        public System.Windows.Forms.Timer timerEve;  
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerEve = new System.Windows.Forms.Timer();
            timerEve.Interval = 1000;
            timerEve.Tick += timerEve_Tick;
            timerEve.Start();
        }

        void timerEve_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
        public System.Timers.Timer timeEveTwo;
        private void button2_Click(object sender, EventArgs e)
        {
            //Thread thread = new Thread(new ParameterizedThreadStart(theout));
            //thread.Start();
            timeEveTwo = new System.Timers.Timer(1000);
            //到达时间，执行事件
            timeEveTwo.Elapsed += new System.Timers.ElapsedEventHandler(theout);
            //执行一次为false 一直执行为true
            timeEveTwo.AutoReset = true;
            timeEveTwo.Start();

        }
        public void theout(object source,System.Timers.ElapsedEventArgs e)
        {
            //if(label2.InvokeRequired)
            //{
            //    Action<string> changetime = (s) => { label2.Text = s.ToString(); };
            //    label2.Invoke(changetime);
            //}
            //else
            //{
                label2.Text = DateTime.Now.ToString();
            //}
        }
              //Callback：一个 TimerCallback 委托，表示要执行的方法。
              //State：一个包含回调方法要使用的信息的对象，或者为空引用（Visual Basic 中为 Nothing）。
              //dueTime：调用 callback 之前延迟的时间量（以毫秒为单位）。指定 Timeout.Infinite 以防止计时器开始计时。指定零 (0) 以立即启动计时器。
              //Period：调用 callback 的时间间隔（以毫秒为单位）。指定 Timeout.Infinite 可以禁用定期终止。
        public System.Threading.Timer threadtimer;

        private void button3_Click(object sender, EventArgs e)
        {
            threadtimer = new System.Threading.Timer(new TimerCallback(timecall),null,0,1000);
        }
        private void timecall(object obj)
        {
            label3.Text = DateTime.Now.ToString();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
