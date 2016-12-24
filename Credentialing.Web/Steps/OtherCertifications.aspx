<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtherCertifications.aspx.cs" Inherits="Credentialing.Web.Steps.OtherCertifications" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<%@ Register Src="~/Usercontrols/RenderAttachments.ascx" TagPrefix="uc" TagName="Attachments" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
    <uc:SidebarProgress runat="server" CurrentStep="8" EnableViewState="false"/>

    <h4>IX. OTHER CERTIFICATIONS (E.G. FLUOROSCOPY, RADIOGRAPHY, ETC.)<br />
        Attach additional sheets if necessary</h4>

    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>

    <asp:Panel runat="server" Visible="False">
        <asp:Label runat="server" AssociatedControlID="tboxPrimaryType" Text="Type:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryType" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryNumber" Text="Number:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryNumber" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryExpirationDate" Text="Expiration Date:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryExpirationDate" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondryType" Text="Type:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondryType" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryNumber" Text="Number:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryNumber" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryExpirationDate" Text="Expiration Date:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryExpirationDate" ClientIDMode="Static" />

        <asp:FileUpload runat="server" ID="fuAttachments" ClientIDMode="Static" AllowMultiple="True" />
        
        <hr/>
        <uc:Attachments ID="ucAttachments" runat="server" EnableViewState="False"/>

        <div class="form-actions">
            <asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
            <asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
        </div>
    </asp:Panel>
</asp:Content>