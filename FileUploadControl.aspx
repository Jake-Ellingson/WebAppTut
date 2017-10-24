<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadControl.aspx.cs" Inherits="WebAppTut.FileUploadControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>File Uploading</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FileUpload runat="server" ID="FileUploadControl1" />
        <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClick="UploadButton_Click" />
        <br /><br />
        <asp:Label runat="server" ID="StatusLabel" Text="Upload Status: " />
    </form>
</body>
</html>
