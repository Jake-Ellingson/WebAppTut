<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="WebAppTut.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ViewState</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox runat="server" ID="NameField" />
        <asp:Button runat="server" ID="SubmitForm" OnClick="SubmitForm_Click" text="Submit & set name" />
        <asp:Button runat="server" ID="RefreshPage" Text="Just Submit" />
        <br /><br />
        Name retrieved from ViewState: <asp:Label runat="server" ID="NameLabel" />
    </form>
</body>
</html>
