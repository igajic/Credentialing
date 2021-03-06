﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="Credentialing.Web.Usercontrols.Login" %>

<div class="form-row">
	<asp:Label runat="server" AssociatedControlID="tboxUsername" Text="Username" EnableViewState="False" />
	<asp:TextBox runat="server" ID="tboxUsername" />
</div>
<div class="form-row">
	<asp:Label runat="server" AssociatedControlID="tboxPassword" Text="Password" EnableViewState="False" />
	<asp:TextBox runat="server" ID="tboxPassword" TextMode="Password" />
</div>
<div class="form-row">
	<a class="register-user js-open-register" href="javascript:;">Register</a>
	<asp:Button runat="server" ID="btnLogin" Text="Login" CssClass="btn submit-login" />
</div>