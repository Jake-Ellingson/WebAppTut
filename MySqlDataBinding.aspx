<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MySqlDataBinding.aspx.cs" Inherits="WebAppTut.MySqlDataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MySql - Data Binding</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList runat="server" ID="ddlUsers" DataValueField="id" DataTextField="name" />
        <br /><br />
        <b>Add person to database:</b><br />
        <asp:Label runat="server" ID="lblConfirm" Text="" />
        <br />
        Name:<br />
        <asp:TextBox runat="server" ID="txtPerson" /><br /><br />
        Country:<br />
        <asp:TextBox runat="server" ID="txtCountry" /><br />
        <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="SubmitPerson_Click" />
    </form>
</body>
</html>
