<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SidebarProgress.ascx.cs" Inherits="Credentialing.Web.Usercontrols.SidebarProgress" %>
<asp:Repeater runat="server" ID="rptSidebarProgress" EnableViewState="False" ClientIDMode="Static">
    <HeaderTemplate><div class="sidebar-progress"></HeaderTemplate>
    <ItemTemplate>
        <asp:Label runat="server" ID="lblStep" EnableViewState="False" ClientIDMode="Static"/>
        <asp:HyperLink runat="server" ID="hlStep" EnableViewState="False" ClientIDMode="Static"/>
    </ItemTemplate>
    <FooterTemplate></div></FooterTemplate>
</asp:Repeater>