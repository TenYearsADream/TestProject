<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Temp.aspx.cs" Inherits="WebApplicationW3C.Temp" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:#e5eecc; text-align:center">
    <form id="form1" runat="server">
        Enter your name:


        <asp:TextBox ID="text1" runat="server"
text="Hello world" OnTextChanged="change" AutoPostBack="true" />
        <p><asp:Label ID="label2" runat="server" /></p>
 
        <asp:TextBox ID="txt1" runat="server" />
        <asp:Button id="btn1" OnClick="submit" Text="Submit" runat="server" />
        <p><asp:Label ID="lable1" runat="server" /></p>







        <asp:RadioButtonList id="countrylist" runat="server">
        <asp:ListItem value="A" text="China" />
        <asp:ListItem value="S" text="Sweden" />
        <asp:ListItem value="F" text="France" />
        <asp:ListItem value="I" text="Italy" />
        </asp:RadioButtonList>

        <br />






        <asp:TextBox name="1tb" ID="tb1" runat="server" />
        <br />

        <asp:TextBox name="2tb" ID="tb2" TextMode="Password" runat="server" />
        <br />

        <asp:TextBox name="3tb" ID="tb3" Text="Hello World" runat="server"/>   
        <br />
        
        <asp:TextBox name="4tb" ID="tb4" TextMode="MultiLine" runat="server" />
        <br />
        
        <asp:TextBox name="5tb" ID="tb5" Rows="5" TextMode="MultiLine"  runat="server" />
        <br />
        
        <asp:TextBox name="6tb" ID="tb6" Columns="30" runat="server" />
        <br />   
        <p>Enter a number from 1 to 100:
            <asp:TextBox ID="tbox1" runat="server" />
            <br />
            <asp:Button Text="Submit" runat="server" />            
        </p>
        <p>
            <asp:RangeValidator ControlToValidate="tbox1" MinimumValue="1" MaximumValue="100"
            Type="Integer" Text="The value must be from 1 to 100!" runat="server"></asp:RangeValidator>
        </p>
        <asp:Button id="button1" Text="Click me!" runat="server"  />

    <div>
        
    </div>
    </form>
    <h1>Hello</h1>
    <h2>Hello</h2>
    <h3><asp:label id="lbl1" runat="server" /></h3>
        <p><%            
                Response.Write(DateTime.Now);          
            %>
        </p>  
</body>
</html>
<script runat="server">
/* Sub submit(sender As Object,e As EventArgs) 
End Sub  */
</script>
