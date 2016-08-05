<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dataBind.aspx.cs" Inherits="WebApplicationW3C.dataBind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:RadioButtonList ID="rdBind" runat="server" />
        <br />
        <asp:DataGrid id="datagrid" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="#FF0066" >
            <ItemStyle BackColor="#66FF99" BorderColor="Blue" BorderStyle="Solid" />
            <PagerStyle BackColor="Fuchsia" />
        </asp:DataGrid>
        <br />
        <!--<asp:DataList FooterStyle-Wrap="true" ID="datalist" AlternatingItemStyle-ForeColor="Yellow" runat="server" >
            <ItemTemplate>
                <h1>Title</h1>
                <b>Directed by:</b>
                <br />
                <b>Description:</b>
            </ItemTemplate>
        </asp:DataList>-->
        
        <br />
        <asp:Table runat="server"/>
    <div>
        
    </div>
    </form>
</body>
</html>
   
