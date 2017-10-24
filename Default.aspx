<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppTut.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.net Tutorial - Master Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button runat="server" Text="Event User Controls" OnClick="EventUserControl_Click" />
        <asp:Button runat="server" Text="Required Fields" OnClick="ReqFields_Click" />
        <asp:Button runat="server" Text="CompareValidator" OnClick="CompareValidator_Click" />
        <asp:Button runat="server" Text="Regular Expression Validator" OnClick="RegExValidator_Click" />
        <asp:Button runat="server" Text="Custom Validator" OnClick="Custom_Click" />
        <asp:Button runat="server" Text ="Intro to Caching (Output Cache)" OnClick="Caching_Click" />
        <asp:Button runat="server" Text="Substitution Caching" OnClick="SubCache_Click" />
        <asp:Button runat="server" Text="Caching Objects" OnClick="CachingObjects_Click" />
        <asp:Button runat="server" Text="Intro to Cookies" OnClick="Cookies_Click" />
        <asp:Button runat="server" Text="Sessions (Cookies)" OnClick="Sessions_Click" />
        <asp:Button runat="server" Text="ViewState (Cookies)" OnClick="ViewState_Click" />
        <asp:Button runat="server" Text="E-mail sending" OnClick="Email_Click" />
        <asp:Button runat="server" Text="File Upload Control" OnClick="FileUpload_Click" />
        <asp:Button runat="server" Text="First Access to MySQL" OnClick="FirstAcc_Click" />
        <asp:Button runat="server" Text="Data Binding" OnClick="DataBinding_Click" />
    </form>
</body>
</html>
