<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheSubstitution.aspx.cs" Inherits="WebAppTut.CacheSubstitution" %>
<%@ OutputCache Duration="120" VaryByParam="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Substitution</title>
</head>
<body>
    <form id="form1" runat="server">
        Cached datestamp:<br />
        <%= DateTime.Now.ToString() %><br /><br />
        Fresh datestamp:<br />
        <asp:Substitution runat="server" ID="UnCachedArea" MethodName="GetFreshDateTime" />
        <br />
        Updates every 120 seconds (Substituion time) Fresh updates every second (Refresh to see both change).
    </form>
</body>
</html>
