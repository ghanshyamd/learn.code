<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CacheControl.ascx.cs" Inherits="learn.asp.net.Caching.CacheControl" %>
<%@ OutputCache Duration="7" VaryByParam="*" %>

<asp:Label ID="lblTime" runat="server" Font-Bold="true" ForeColor="Blue" />