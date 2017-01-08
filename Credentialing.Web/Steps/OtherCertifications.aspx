<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtherCertifications.aspx.cs" Inherits="Credentialing.Web.Steps.OtherCertifications" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<%@ Register Src="~/Usercontrols/RenderAttachments.ascx" TagPrefix="uc" TagName="Attachments" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
    <uc:SidebarProgress runat="server" CurrentStep="9" EnableViewState="false"/>

    <div class="form-block">
        <div class="form-heading">
            <h2><strong>9.</strong>  OTHER CERTIFICATIONS (E.G. FLUOROSCOPY, RADIOGRAPHY, ETC.)</h2>
        </div>
        
        <div class="row">
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryType" Text="Type:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryType" ClientIDMode="Static" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryNumber" Text="Number:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryNumber" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryExpirationDate" Text="Expiration Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryExpirationDate" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
        </div>
        <hr/>
        <div class="row">
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxSecondryType" Text="Type:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondryType" ClientIDMode="Static" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryNumber" Text="Number:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryNumber" ClientIDMode="Static" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryExpirationDate" Text="Expiration Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryExpirationDate" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
        </div>
        <hr/>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" Text="Attach additional sheets if necessary" CssClass="label" />
				<div class="file-upload">
					<asp:FileUpload ClientIDMode="Static" runat="server" ID="fuAttachments" AllowMultiple="True"/>
					<span class="temp-filename"></span>
					<span class="upload-file-btn"><i class="ico"></i></span>
				</div>
			</div>
		</div>
        
        <hr/>
        <uc:Attachments ID="ucAttachments" runat="server" EnableViewState="False"/>
    </div>
    <div class="form-actions">
        <asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
        <asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
    </div>

</asp:Content>