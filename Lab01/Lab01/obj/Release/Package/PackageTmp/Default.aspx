<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab01._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">Lab01 </p>
        <asp:Label ID="Label1" runat="server" Text="Сюда нужно вставить текст из TextBox"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Вставляем в label" OnClick="Button1_Click" />
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected ="True" Value="чтобы было"></asp:ListItem>
            <asp:ListItem Value ="her1">херня 1</asp:ListItem>
            <asp:ListItem Value="her2">херня 2</asp:ListItem>
            <asp:ListItem Value="her3">херня 3</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="row">
    </div>

</asp:Content>
