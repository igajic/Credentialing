<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RenderAttachments.ascx.cs" Inherits="Credentialing.Web.Usercontrols.RenderAttachments" %>
<asp:Repeater runat="server" ID="rptAttachments">
	<HeaderTemplate>
	<div class="row attachments">
		<div class="col-md-6">
			<span class="label">Attachments:</span>
			<ul>
	</HeaderTemplate>
	<ItemTemplate>
		<li>
			<asp:HyperLink runat="server" ID="hlAttachment"/>
		</li>
	</ItemTemplate>
	<FooterTemplate>
			</ul>
		</div>
	</div>
	<hr />
	</FooterTemplate>
</asp:Repeater>