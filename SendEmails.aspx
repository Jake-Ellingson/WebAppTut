<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmails.aspx.cs" Inherits="WebAppTut.SendEmails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Send E-mail Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <b>Contact Us</b><br /><br />
        Your name:<br />
        <asp:TextBox runat="server" ID="txtFrom" />
        <br />
        Subject:<br />
        <asp:TextBox runat="server" ID="txtSubject" />
        <br />
        Message:<br />
        <asp:TextBox runat="server" ID="txtMsg" TextMode="MultiLine" />
        <br /><br />
        <asp:Button runat="server" ID="btnSend" Text="Send" OnClick="Send_Click" />
    </form>
</body>
</html>
