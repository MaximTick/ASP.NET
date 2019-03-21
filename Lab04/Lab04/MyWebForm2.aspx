<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWebForm2.aspx.cs" Inherits="Lab04.MyWebForm2" Theme="MyFirstSkin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" Text="Кнопка"/>
            <asp:Button runat="server" EnableTheming="false" Text="Без темы" />
            <asp:Label runat="server" Text="Shalom"></asp:Label>
            <asp:Label runat="server" SkinID="task2" Text="Shalom this is SkinID"></asp:Label>
        </div>
    </form>
</body>
</html>
