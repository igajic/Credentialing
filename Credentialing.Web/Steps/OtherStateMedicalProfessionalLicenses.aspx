<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtherStateMedicalProfessionalLicenses.aspx.cs" Inherits="Credentialing.Web.Steps.OtherStateMedicalProfessionalLicenses" MasterPageFile="../Main.Master" %>
<%@ Register Src="~/Usercontrols/RenderAttachments.ascx" TagPrefix="uc" TagName="Attachments" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
	<uc:SidebarProgress ID="SidebarProgress1" runat="server" CurrentStep="11" EnableViewState="false"/>

	<div class="form-block">
		<div class="row">
			<div class="col-md-12">
			    <p>List All Medical/Professional Licenses Now or Previously Held.</p>
		    </div>
        </div>
			
		<div class="row">
			<div class="col-lg-3 col-md-6 md-margin-bot">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryState" Text="State:" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxPrimaryState" ClientIDMode="Static"/>
			</div>
			<div class="col-lg-3 col-md-6 md-margin-bot">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryLicenseNumber" Text="License Number:" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxPrimaryLicenseNumber" ClientIDMode="Static"/>
			</div>
			<div class="col-lg-3 col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryExpirationDate" Text="Exp. Date" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxPrimaryExpirationDate" ClientIDMode="Static" CssClass="datepicker-default"/>
			</div>
			<div class="col-lg-3 col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryLastExpirationDate" Text="If inactive, last Exp. Date:" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxPrimaryLastExpirationDate" ClientIDMode="Static" CssClass="datepicker-default"/>
			</div>
		</div>
		<hr/>

		<div class="row">
			<div class="col-lg-3 col-md-6 md-margin-bot">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryState" Text="State:" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxSecondaryState" ClientIDMode="Static"/>
			</div>
			<div class="col-lg-3 col-md-6 md-margin-bot">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryLicenseNumber" Text="License Number:" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxSecondaryLicenseNumber" ClientIDMode="Static"/>
			</div>
			<div class="col-lg-3 col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryExpirationDate" Text="Exp. Date" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxSecondaryExpirationDate" ClientIDMode="Static" CssClass="datepicker-default"/>
			</div>
			<div class="col-lg-3 col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryLastExpirationDate" Text="If inactive, last Exp. Date:" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxSecondaryLastExpirationDate" ClientIDMode="Static" CssClass="datepicker-default"/>
			</div>
		</div>
		<hr/>

		<div class="row">
			<div class="col-lg-3 col-md-6 md-margin-bot">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryState" Text="State:" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxTertiaryState" ClientIDMode="Static"/>
			</div>
			<div class="col-lg-3 col-md-6 md-margin-bot">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryLicenseNumber" Text="License Number:" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxTertiaryLicenseNumber" ClientIDMode="Static"/>
			</div>
			<div class="col-lg-3 col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryExpirationDate" Text="Exp. Date" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxTertiaryExpirationDate" ClientIDMode="Static" CssClass="datepicker-default"/>
			</div>
			<div class="col-lg-3 col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryLastExpirationDate" Text="If inactive, last Exp. Date:" EnableViewState="False"/>
				<asp:TextBox runat="server" ID="tboxTertiaryLastExpirationDate" ClientIDMode="Static" CssClass="datepicker-default"/>
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