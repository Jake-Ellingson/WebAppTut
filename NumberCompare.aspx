<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NumberCompare.aspx.cs" Inherits="WebAppTut.NumberCompare" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Comparing Numbers</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Small number:<br />
        <asp:TextBox runat="server" ID="txtSmallNumber" /><br /><br />
        Big number:<br />
        <asp:TextBox runat="server" ID="txtBigNumber" /><br /><br />
        <asp:CompareValidator runat="server" ID="cmpNumbers" ControlToValidate="txtSmallNumber" ControlToCompare="txtBigNumber" Operator="LessThan" Type="Integer" ErrorMessage="The first number should be smaller than the second number!" />
        <br /><br />
        <asp:Button runat="server" ID="btnSubmit" Text="OK" OnClick="btn_SubmitFormClick" />
    </div>
    </form>
</body>
</html>
