﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="WCF.Demo.Client.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        添加页面：<br />
        用户名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
        密码：<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
        描述：<asp:TextBox ID="txtDiscribe" runat="server" TextMode="MultiLine"></asp:TextBox><br />
        <asp:Button ID="btnSubmit" Text="提交" runat="server" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>
