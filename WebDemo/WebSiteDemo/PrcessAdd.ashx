<%@ WebHandler Language="C#" Class="PrcessAdd" %>

using System;
using System.Web;

public class PrcessAdd : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        //拿到提交来打数据
        string txtstuno = context.Request.Form["txtstuno"];
        string txtstuname = context.Request.Form["txtstuname"];
        string txtstusex = context.Request.Form["txtstusex"];
        string txtstumajor = context.Request.Form["txtstumajor"];
        string txtstutel = context.Request.Form["txtstutel"];
        //接下来到数据库中做插入操作
        //插入成功之后
        context.Response.Redirect("Handler.ashx");

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}