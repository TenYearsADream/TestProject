using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("hh");
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
            if(DateTime.Now.Hour==21&&DateTime.Now.Minute==15&&DateTime.Now.Second==5)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"‪‪C:\Users\XiaofengWang\Desktop\renxi.mp3";
                sp.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
