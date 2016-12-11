<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SidebarProgress.ascx.cs" Inherits="Credentialing.Web.Usercontrols.SidebarProgress" %>

<asp:Panel runat="server" ID="pnlCurrentStep" EnableViewState="false" ClientIDMode="Static" CssClass="current-step js-toggle-steps">
	<span class="progress">Step</span>
	<span class="step-number"><asp:Literal  runat="server" EnableViewState="False" ID="ltrProgress"/></span>
	<h2 class="step-name"><asp:Literal runat="server" ID="ltrCurrentStep" EnableViewState="False"/></h2>
</asp:Panel>

<asp:Repeater runat="server" ID="rptSidebarProgress" EnableViewState="False" ClientIDMode="Static">
	<HeaderTemplate>
	<div class="steps-progress">
		<ul>
	</HeaderTemplate>
	<ItemTemplate>
		<li class="step" runat="server" id="liStep" EnableViewState="False">
			<asp:HyperLink runat="server" ID="hlStepLink" EnableViewState="False" ClientIDMode="Static" CssClass="overlay-link"/>
			<asp:Label runat="server" ID="lblStep" EnableViewState="False" ClientIDMode="Static" CssClass="step-circle"/>
			<span class="step-name"><asp:Literal runat="server" ID="hlStep" EnableViewState="False" ClientIDMode="Static"/></span>
			<span class="short-description"><asp:Literal ID="ltrShortDesc" runat="server" EnableViewState="False"/></span>
		</li>
	</ItemTemplate>
	<FooterTemplate>
		</ul>
	</div>
	</FooterTemplate>
</asp:Repeater>