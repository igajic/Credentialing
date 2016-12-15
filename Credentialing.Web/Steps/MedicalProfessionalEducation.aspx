<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicalProfessionalEducation.aspx.cs" Inherits="Credentialing.Web.Steps.MedicalProfessionalEducation"  MasterPageFile="../Main.Master"%>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
	<uc:SidebarProgress runat="server" CurrentStep="5" EnableViewState="false"/>
	
	<div class="form-block">
		<div class="form-heading">
			<h2><strong>5.</strong> Medical / Professional education</h2>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMedicalProfessionalSchoolFirst" Text="Medical/Professional School:" EnableViewState="False" />
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMedicalProfessionalSchoolFirst"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxDegreeReceivedFirst" Text="Degree Received:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDegreeReceivedFirst"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxDateGraduationFirst" Text="Date of Graduation (mm/yy)" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDateGraduationFirst" placeholder="mm/yy" CssClass="datepicker datepicker-monthly"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingAdrressFirst" Text="Mailing Address:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAdrressFirst"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingCityFirst" Text="City:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingCityFirst"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingStateFirst" Text="State:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingStateFirst"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingZipFirst" Text="ZIP:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingZipFirst"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMedicalProfessionalSchoolSecond" Text="Medical/Professional School:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMedicalProfessionalSchoolSecond"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxDegreeReceivedSecond" Text="Degree Received:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDegreeReceivedSecond"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxDateGraduationSecond" Text="Date of Graduation (mm/yy)" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDateGraduationSecond" placeholder="mm/yy" CssClass="datepicker datepicker-monthly"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingAdrressSecond" Text="Mailing Address:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAdrressSecond"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingCitySecond" Text="City:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingCitySecond"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingStateSecond" Text="State:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingStateSecond"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingZipSecond" Text="ZIP:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingZipSecond"/>
			</div>
		</div>
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
		<hr />
		<asp:Repeater runat="server" ID="rptAttachments" Visible="False">
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
	</div>
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
</asp:Content>