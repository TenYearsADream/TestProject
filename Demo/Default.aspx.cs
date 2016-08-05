using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //数据库连接字符串键名
        string name = "SqlConnection";
        //连接字符串
        string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        //数据提供程序名称
        string providerName = ConfigurationManager.ConnectionStrings["SqlConnection"].ProviderName;

        StringBuilder builder = new StringBuilder(string.Empty);
        builder.AppendFormat("<b>连 接 字符串键名：{0}</b><br/>", name);
        builder.AppendFormat("<b>数据库连接字符串：{0}</b><br/>", connectionString);
        builder.AppendFormat("<b>数据提供程序名称：{0}</b><br/>", providerName);
        //显示Web.config中配置的连接字符串
        this.Response.Write(builder.ToString());
    }
}
