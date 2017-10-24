<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="WebAppTut.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookies</title>
</head>
<body runat="server" id="BodyTag">
    <form id="form1" runat="server">
        <asp:DropDownList runat="server" ID="ColorSelector" AutoPostBack="true" OnSelectedIndexChanged="ColorSelector_IndexChanged">
            <asp:ListItem Value="White" Selected="True">Select color...</asp:ListItem>
            <asp:ListItem Value="Red">Red</asp:ListItem>
            <asp:ListItem Value="Green">Green</asp:ListItem>
            <asp:ListItem Value="Blue">Blue</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
