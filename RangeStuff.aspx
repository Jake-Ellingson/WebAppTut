<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RangeStuff.aspx.cs" Inherits="WebAppTut.RangeStuff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Range Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        4 digit number:<br />
        <asp:TextBox runat="server" ID="txtNumber" />
        <asp:RegularExpressionValidator runat="server" ID="rexNumber" ControlToValidate="txtNumber" ValidationExpression="^[0-9]{4}$" ErrorMessage="Please enter a 4 digit number!" CssClass="required"/>
        <br /><br />
        <asp:Button runat="server" ID="btnSubmit" />
    </div>
    </form>
</body>
</html>
