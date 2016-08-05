<%@ WebHandler Language="C#" Class="ProcessEdit" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
using System.IO;

public class ProcessEdit : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //拿数据
      
        string qStuname = context.Request["txtstuname"];
        string qStusex = context.Request["txtstusex"];
        string qStumajor = context.Request["txtstumajor"];
        string qStutel = context.Request["txtstutel"];

        int IdStuno = int.Parse(context.Request["hidId"]);
        
         string str = ConfigurationManager.ConnectionStrings["dianxin122"].ConnectionString;
         using (SqlConnection conn = new SqlConnection(str))
        {
             conn.Open();
             using (SqlCommand cmd = new SqlCommand("update dbo.stuinfo set stuname=@stuname, stusex=@stusex,stumajor=@stumajor,stutel=@stutel where Stuno=@stuno", conn))
             {
                 cmd.Parameters.Add(new SqlParameter("@stuno", IdStuno));
                 cmd.Parameters.Add(new SqlParameter("@stuname", qStuname));
                 cmd.Parameters.Add(new SqlParameter("@stusex", qStusex));
                 cmd.Parameters.Add(new SqlParameter("@stumajor", qStumajor));
                 cmd.Parameters.Add(new SqlParameter("@stutel", qStutel));
                 int rows = cmd.ExecuteNonQuery();
                 context.Response.Redirect("Handler.ashx");
             }
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}