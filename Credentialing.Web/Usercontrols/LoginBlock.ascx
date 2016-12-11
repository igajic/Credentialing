<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginBlock.ascx.cs" Inherits="Credentialing.Web.Usercontrols.LoginBlock" %>

<asp:Panel runat="server" ID="pnlLogin" CssClass="login-btn">
	<a class="js-open-login" href="javascript:;">Login</a>
</asp:Panel>

<asp:Panel runat="server" ID="pnlLoggedIn" CssClass="login-btn" Visible="False" >
	<span class="logged-user">Welcome, <asp:Literal runat="server" ID="ltrUsername"/></span>
	<asp:LinkButton runat="server" ID="lbLogout" Text="Logout" CssClass="logout-btn"/>
</asp:Panel>
