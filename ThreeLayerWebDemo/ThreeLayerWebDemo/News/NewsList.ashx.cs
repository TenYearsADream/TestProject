using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeLayerWebDemo.News
{
    /// <summary>
    /// Summary description for NewsList
    /// </summary>
    public class NewsList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            BLL.NewInfoService newInfoService = new NewInfoService();
            newInfoService.GetAllNews();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}