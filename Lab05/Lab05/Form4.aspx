<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form4.aspx.cs" Inherits="Lab05.Form4" %>
<%@ OutputCache Duration="20" VaryByParam="None" VaryByCustom="maxik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Now: "></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Кнопка" OnClick="Button1_Click" Width="70px" />
        </div>
    </form>
</body>
</html>
