<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.ascx.cs" Inherits="Credentialing.Web.Usercontrols.MainMenu" %>
<nav class="main-nav">
	<ul>
		<li id="liPhysician" runat="server" EnableViewState="False" clientidmode="Static">
			<a href="/Dashboard/Physician.aspx">My Dashboard</a>
		</li>
		<li id="liAdmin" runat="server" EnableViewState="False" clientidmode="Static">
			<a href="/Dashboard/Administrator.aspx">Administrator Dashboard</a>
		</li>
	</ul>
</nav>