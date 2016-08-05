using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WCFBuyPiao;

namespace 检测服务Form
{
    public partial class 检测服务 : Form
    {
        public 检测服务()
        {
            InitializeComponent();
        }
        ServiceHost host = null;

        private void button1_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(WCFBuyPiao.Service1));
            host.Open();
            this.label1.Text = "服务已启动";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(host.State!=CommunicationState.Closed)
            {
                host.Close();
            }
            this.label1.Text = "服务已关闭";
        }

    }
}
