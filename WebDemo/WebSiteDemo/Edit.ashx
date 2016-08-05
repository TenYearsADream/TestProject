<%@ WebHandler Language="C#" Class="Edit" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
using System.IO;

public class Edit : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";

        if (context.Request.HttpMethod.ToLower().Equals("get"))
        {

            string Stuno = context.Request["Stuno"];
            int qStuno = int.Parse(Stuno);

            string str = ConfigurationManager.ConnectionStrings["dianxin122"].ConnectionString;
            string strSql = "select stuno, stuname, stusex, stumajor, stutel from dbo.STUINFO where Stuno=@stuno";

            using (SqlDataAdapter adapter = new SqlDataAdapter(strSql, str))
            {
                adapter.SelectCommand.Parameters.Add("@stuno", qStuno);

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                string strResult = File.ReadAllText(context.Request.MapPath("EditTemp.html"));
               
                strResult = strResult.Replace("@txtstuname", dt.Rows[0]["stuname"].ToString());
                strResult = strResult.Replace("@txtstusex", dt.Rows[0]["stusex"].ToString());
                strResult = strResult.Replace("@txtstumajor", dt.Rows[0]["stumajor"].ToString());
                strResult = strResult.Replace("@txtstutel", dt.Rows[0]["stutel"].ToString());
                strResult = strResult.Replace("@stuno", dt.Rows[0]["stuno"].ToString());
                
                context.Response.Write(strResult);
            }
        }
        else
        {
            //处理表单
            
        }   
            
            
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}