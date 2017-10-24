<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidator.aspx.cs" Inherits="WebAppTut.CustomValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Validator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Custom text:<br />
        <asp:TextBox runat="server" ID="txtCustom" />
        <asp:CustomValidator runat="server" ID="cusCustom" ControlToValidate="txtCustom" OnServerValidate="cusCustom_ServerValidate" ErrorMessage="Must be 8 characters long!" BackColor="Red" />
    </div>
    </form>
</body>
</html>
