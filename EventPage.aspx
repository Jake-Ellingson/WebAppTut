<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventPage.aspx.cs" Inherits="WebAppTut.EventPage" %>

<%@ Register TagPrefix="My" TagName="EventUserControl" Src="~/EventUserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Event User Control</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <My:EventUserControl runat="server" ID="MyEventUserControl" OnPageTitleUpdated="MyEventUserControl_PageTitleUpdated" />
    </div>
    </form>
</body>
</html>
