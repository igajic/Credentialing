<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicalProfessionalEducation.aspx.cs" Inherits="Credentialing.Web.Steps.MedicalProfessionalEducation"  MasterPageFile="../Main.Master"%>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<div class="form-block">
		<div class="form-heading">
			<h2><strong>5.</strong> Medical / Professional education</h2>
		</div>
		<h1>Coming soon</h1>
		<asp:Panel ID="Panel1" runat="server" Enabled="false" Visible="false">
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
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDateGraduationFirst"/>
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
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDateGraduationSecond"/>
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
					<asp:FileUpload ClientIDMode="Static" runat="server" ID="fuAttachments"/>
					<span class="temp-filename"></span>
					<span class="upload-file-btn"><i class="ico"></i></span>
				</div>
			</div>
		</div>
		</asp:Panel>
	</div>
	<asp:Panel ID="Panel2" runat="server" Enabled="false" Visible="false">
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
	</asp:Panel>
</asp:Content>