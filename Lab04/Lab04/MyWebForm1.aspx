<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWebForm1.aspx.cs" Inherits="Lab04.MyWebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="MyCSSClass.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" CssClass="button" Text="БГТУ" /> <br/>
            <asp:Label ID="Label1" runat="server" Text="Label"  CssClass="ASP.NET"/>
            <br /><br />
            <asp:Button ID="Button2" runat="server" Text="БГТУ" /> <br/>
            <asp:Label ID="Label2" runat="server" Text="ASP.NET" />
        </div>
    </form>
</body>
</html>
