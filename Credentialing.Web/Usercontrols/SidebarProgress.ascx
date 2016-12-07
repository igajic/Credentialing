<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SidebarProgress.ascx.cs" Inherits="Credentialing.Web.Usercontrols.SidebarProgress" %>
<asp:Panel runat="server" ID="pnlCurrentStep" EnableViewState="false" ClientIDMode="Static" CssClass="step">
    <span><asp:Literal  runat="server" EnableViewState="False" ID="ltrProgress"/></span>
    <asp:Literal runat="server" ID="ltrCurrentStep" EnableViewState="False"/>
</asp:Panel>


<asp:Repeater runat="server" ID="rptSidebarProgress" EnableViewState="False" ClientIDMode="Static">
	<HeaderTemplate>
	<div class="steps-progress">
		<ul>
	</HeaderTemplate>
	<ItemTemplate>
		<li class="step" runat="server" id="liStep" EnableViewState="False">
			<asp:Label runat="server" ID="lblStep" EnableViewState="False" ClientIDMode="Static"/>
			<asp:HyperLink runat="server" ID="hlStep" EnableViewState="False" ClientIDMode="Static"/>
		    <p><asp:Literal ID="ltrShortDesc" runat="server" EnableViewState="False"/></p>
		</li>
	</ItemTemplate>
	<FooterTemplate>
		</ul>
	</div>
	</FooterTemplate>
</asp:Repeater>