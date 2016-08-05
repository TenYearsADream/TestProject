<%@ WebHandler Language="C#" Class="Delete" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
using System.IO;

public class Delete : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //拿到stuno
        string Stuno = context.Request["Stuno"];
        int qStuno = int.Parse(Stuno);

        string str = ConfigurationManager.ConnectionStrings["dianxin122"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(str))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("delete from dbo.stuinfo where Stuno=@stuno", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@Stuno",qStuno));
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    context.Response.Redirect("Handler.ashx");
                }
                else
                {
                    context.Response.Write("删除失败");
                }
            }
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}