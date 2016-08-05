<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Implements Interface="Page_write" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
<script runat="server">
    public interface Page_write
    {
        void page_W();
    }
    public void Page_W()
    {
        Response.Write("一个接口的方法");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Page_W();
    }
</script>