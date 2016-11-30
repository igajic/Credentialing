<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginBlock.ascx.cs" Inherits="Credentialing.Web.Usercontrols.LoginBlock" %>

<asp:Panel runat="server" ID="pnlLogin" CssClass="login-btn">
    <a class="js-open-login" href="javascript:;">Login</a>
</asp:Panel>

<asp:Panel runat="server" ID="pnlLoggedIn" CssClass="login-btn" Visible="False" >
    Logged in as: <asp:Literal runat="server" ID="ltrUsername"/> <asp:LinkButton runat="server" ID="lbLogout" Text="Logout"/>

</asp:Panel>
