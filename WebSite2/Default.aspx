<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        string table_txt = "<table border=\"1\" width=\"300px\">";
        table_txt += "<tr>";
        table_txt += "<td>";
        table_txt += "&nbsp;</td>";
        table_txt += "<td>";
        table_txt += "&nbsp;</td>";
        table_txt += "</tr>";
        table_txt += "<tr>";
        table_txt += "<td>";
        table_txt += "&nbsp;</td>";
        table_txt += "<td>";
        table_txt += "&nbsp;</td>";
        table_txt += "</tr>";
        table_txt += "</table>";

        Response.Write(table_txt);  
    }
</script>
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
