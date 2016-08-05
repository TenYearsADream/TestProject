using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write("一个应用程序开始！" + "<br/>");
        //Response.ContentType = "image/JPEG";//图片
        //Response.WriteFile("test.jpg");      
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "hahaha";
        if(TextBox1.Text!=null)
        {
            TextBox2.Text = "value";
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}