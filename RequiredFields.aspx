<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequiredFields.aspx.cs" Inherits="WebAppTut.RequiredFields" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Making required fields</title>
</head>
<body>
    <form id="form1" runat="server">
        Your name:<br />
        <asp:TextBox runat="server" ID="txtName" />
        <asp:RequiredFieldValidator runat="server" ID="reqName" ControlToValidate="txtname" ErrorMessage="Please enter your name!" BackColor="Red" />
        <br /><br />
        <asp:Button runat="server" ID="btnSubmitForm" Text="Ok" onClick="btnSubmitForm_Click"/>
    </form>
</body>
</html>
