<%@ WebHandler Language="C#" Class="SelfIncrease" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
using System.IO;

public class SelfIncrease : IHttpHandler {
     private int i = 0;
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        string fileTxt = File.ReadAllText(context.Request.MapPath("Self.html"));
        if(context.Request.HttpMethod.ToLower().Equals("get"))
        {
            string str = fileTxt.Replace("@num", 0.ToString());
            context.Response.Write(str);
        }
        else
        {
            int num = int.Parse(context.Request["num"]) + 1;
            string str = fileTxt.Replace("@num", num.ToString());
            context.Response.Write(str);
        }

        i++;
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}