<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cachin.aspx.cs" Inherits="WebAppTut.Cachin" %>
<%@ OutputCache Duration="10" VaryByParam="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Caching</title>
</head>
<body>
    <form id="form1" runat="server">
        <%= DateTime.Now.ToString() %><br />
         Time updates every 10 seconds (Must Refresh to get new time).
    </form>
</body>
</html>
