<%@ Register Src="CacheControl.ascx" TagName="CacheControl" TagPrefix="uc1" %>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="learn.asp.net.Caching.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fragment Caching in Asp.Net with Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Refresh the Page Time Will Update Only After Every 5 Seconds</p>
            <uc1:CacheControl ID="WebUserControl1" runat="server" />
        </div>
    </form>
</body>
</html>
