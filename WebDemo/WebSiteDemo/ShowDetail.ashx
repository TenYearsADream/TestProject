<%@ WebHandler Language="C#" Class="ShowDetail" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
using System.IO;

public class ShowDetail : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        StringBuilder sb = new StringBuilder();
        //context.Response.Write("Hello World");
        string Stuno=context.Request.QueryString["Stuno"];
        int qStuno = int.Parse(Stuno);
        string str = ConfigurationManager.ConnectionStrings["dianxin122"].ConnectionString;
        string strSql = "select stuno, stuname, stusex, stumajor, stutel from dbo.STUINFO where Stuno=@stuno";
        
        using(SqlDataAdapter adapter=new SqlDataAdapter(strSql,str))
        {
            DataTable dt = new DataTable();
            adapter.SelectCommand.Parameters.Add("@stuno", qStuno);
            adapter.Fill(dt);
            
            sb.AppendFormat("<tr><td>stuno:</td><td>{0}</td></tr>", dt.Rows[0]["stuno"]);
            sb.AppendFormat("<tr><td>stuname:</td><td>{0}</td></tr>", dt.Rows[0]["stuname"]);
            sb.AppendFormat("<tr><td>stusex:</td><td>{0}</td></tr>", dt.Rows[0]["stusex"]);
            sb.AppendFormat("<tr><td>stumajor:</td><td>{0}</td></tr>", dt.Rows[0]["stumajor"]);
            sb.AppendFormat("<tr><td>stutel:</td><td>{0}</td></tr>", dt.Rows[0]["stutel"]);
            
        }
        //吧相对网站的根目录的路径转成磁盘上的绝对路径
        string path=context.Request.MapPath("/ShowD.html");
        string textTemp=File.ReadAllText(path);
        string result=textTemp.Replace("@StrTrBody",sb.ToString());
        context.Response.Write(result);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}