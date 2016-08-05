<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        //context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        //context.Response.ContentType = "text/html";
        //context.Response.Write("<html><head></head><body></body><hl>hello ASP</hl></html>");
        //context.Response.ContentType = "image/jpg";
        //context.Response.WriteFile("11.jpg");
        context.Response.ContentType = "text/html";
        StringBuilder sb = new StringBuilder();
        sb.Append("<html><head></head><body><a href='AddInfo.html'>添加</a>");
        
        //context.Response.WriteFile("11.jpg");

        sb.Append("<table><tr><th>stuno</th><th>stusex</th><th>stuname</th><th>操作</th></tr>");
        string str=ConfigurationManager.ConnectionStrings["dianxin122"].ConnectionString;
        using(SqlConnection conn=new SqlConnection(str))
        {
            conn.Open();
            using(SqlCommand cmd=new SqlCommand("select top(10) stuno, stuname, stusex, stumajor, stutel from dbo.stuinfo",conn))
            {
                using(var reader=cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td><a href='ShowDetail.ashx?Stuno={0}'>详情</a></td>&nbsp<td><a onclick='return confirm(\"是否要删除?\")' href='Delete.ashx?Stuno={0}'>删除</a>&nbsp<a href='Edit.ashx?Stuno={0}'>修改</a></td></tr>", reader["stuno"], reader["stusex"], reader["stuname"]);
                    }
                }
            }
        }
        sb.Append("</table>");
        sb.Append("</body></html>");
        context.Response.Write(sb.ToString());
    }
    
    public bool IsReusable {
        get {
            return false;
        }
    }
}