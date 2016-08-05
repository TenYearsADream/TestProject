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

namespace timerandpic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = @"‪C:\Users\XiaofengWang\Desktop\renxi.mp3";
            //sp.Play();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\XiaofengWang\Desktop\pic\1.JPG");
            pictureBox2.Image = Image.FromFile(@"C:\Users\XiaofengWang\Desktop\pic\1.JPG");
            pictureBox3.Image = Image.FromFile(@"C:\Users\XiaofengWang\Desktop\pic\1.JPG");
            pictureBox4.Image = Image.FromFile(@"C:\Users\XiaofengWang\Desktop\pic\1.JPG");
            pictureBox5.Image = Image.FromFile(@"C:\Users\XiaofengWang\Desktop\pic\1.JPG");
            pictureBox6.Image = Image.FromFile(@"C:\Users\XiaofengWang\Desktop\pic\1.JPG");
        }
        string[] path = System.IO.Directory.GetFiles(@"C:\Users\XiaofengWang\Desktop\pic");
        //int i = 0;
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //i++;
            //if(i==path.Length)
            //{
            //    i = 0;
            //}
            pictureBox1.Image = Image.FromFile(path[r.Next(0,path.Length)]);
            pictureBox2.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox3.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox4.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox5.Image = Image.FromFile(path[r.Next(0, path.Length)]);
            pictureBox6.Image = Image.FromFile(path[r.Next(0, path.Length)]);
        }
    }
}
