<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="master.aspx.cs" Inherits="WebApplicationW3C.master" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    @RenderPage("header.cshtml")<!--从不同的文件导入内容-->
    <h1>Hello Web Pages</h1>
    <p>This is a paragraph</p>
    @RenderPage("footer.cshtml")
    <form id="form1" runat="server">
    <div >
      
      
         <!--<link rel="stylesheet" type="text/html" href="index.html" />-->
        <button>
            <a href="index.html" target="_blank" >test</a>
        </button>
    </div>
    </form>
</body>
</html>
