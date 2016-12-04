<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InternshipPGYI.aspx.cs" Inherits="Credentialing.Web.Steps.InternshipPGYI" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<div class="form-block">
		<div class="form-heading">
			<h2><strong>6.</strong> Internship / PGYI</h2>
		</div>
		<h1>Coming soon</h1>
		<asp:Panel ID="Panel1" runat="server" Enabled="false" Visible="false">
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
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxFromDate"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxToDate" Text="To: (mm/yy)" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxToDate"/>
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
		</asp:Panel>
	</div>
	<asp:Panel ID="Panel2" runat="server" Enabled="false" Visible="false">
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
	</asp:Panel>
</asp:Content>