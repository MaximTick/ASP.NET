<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyForm.aspx.cs" Inherits="Lab01.MyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <asp:CheckBox ID="CheckBox1" runat="server" text="Красный" OnCheckedChanged="CheckBox1_CheckedChanged" Autopostback="true"/>
    </form>
</body>
</html>
