using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationW3C
{
    public partial class Temp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submit(object sender, EventArgs e)
        {
            lable1.Text = "这是点击事件" + txt1.Text;
        }

        protected void change(object sender, EventArgs e)
        {
            label2.Text = "改变" + text1.Text;
        }
    }
}