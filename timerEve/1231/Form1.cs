using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1231
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "You did not enter a server name.Cancel this operation?";
            string caption = "No Server Name Specified";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            //DialogResult result = MessageBox.Show(this, message, caption, buttons);

            //MessageBoxDefaultButton b = MessageBoxDefaultButton.Button1;
            //DialogResult result = MessageBox.Show(this,message ,caption);

            MessageBoxOptions op = MessageBoxOptions.DefaultDesktopOnly;
            DialogResult result = MessageBox.Show(message, caption);

            //if(result==DialogResult.Yes)
            //{
            //    this.Close();
            //}
            //else if(result==DialogResult.No)
            //{
            //    this.Text = "No";
            //}
            //else if(result==DialogResult.Cancel)
            //{
            //    this.Text = "Cancel";
            //}
        }
    }
}
