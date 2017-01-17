<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InternshipPGYI.aspx.cs" Inherits="Credentialing.Web.Steps.InternshipPGYI" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<%@ Register Src="~/Usercontrols/RenderAttachments.ascx" TagPrefix="uc" TagName="Attachments" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
    <uc:SidebarProgress runat="server" CurrentStep="6" EnableViewState="false"/>

	<div class="form-block">
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxInstitution" Text="Institution" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxInstitution"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxProgramDirector" Text="Program Director:" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxProgramDirector"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingAddress" Text="Mailing Address:" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAddress"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingCity" Text="City:" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingCity"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingStateCountry" Text="State & Country:" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingStateCountry"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingZip" Text="ZIP:" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingZip" />
			</div>
		</div>
		<div class="row">
			<div class="col-md-12">
				<asp:Label runat="server" AssociatedControlID="tboxTypeInternship" Text="Type of Internship:" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTypeInternship"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSpecialty" Text="Specialty:" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSpecialty"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxFromDate" Text="From: (mm/yy)" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxFromDate" CssClass="datepicker-monthly"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxToDate" Text="To: (mm/yy)" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxToDate" CssClass="datepicker-monthly"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" Text="Attach additional sheets if necessary" CssClass="label" />
				<div class="file-upload">
					<asp:FileUpload ClientIDMode="Static" runat="server" ID="fuInternship" AllowMultiple="True"/>
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