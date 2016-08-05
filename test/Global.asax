<%@ Application Language="C#" %>

<script runat="server">
    
    public static int App_static = 0;
    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        //App_static += 1;
      
    }
    //protected void Application_PostAcquireRequestState(object sender, EventArgs e)
    //{
    //    App_static += 1;
    //    Response.Write("序号:" + App_static.ToString() + ",激发postAcquireRequestState事件" + "<br/>");
    //}
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
    //protected void Application_EndRequest(object sender, EventArgs e)
    //{
    //    App_static += 1;
    //    Response.Write("序号:" + App_static.ToString() + ",激发endRequest事件" + "<br/>");
    //}
</script>
