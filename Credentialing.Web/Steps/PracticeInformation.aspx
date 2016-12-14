<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PracticeInformation.aspx.cs" Inherits="Credentialing.Web.Steps.PracticeInformation" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<uc:SidebarProgress runat="server" CurrentStep="3" EnableViewState="false"/>
	<div class="form-block">
		<div class="form-heading">
			<h2><strong>3.</strong> Practice information</h2>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPracticeName" Text="Practice Name (if applicable)" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPracticeName"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxDepartmentName" Text="Department Name (If Hospital Based)" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDepartmentName"/>
			</div>
		</div>
		<!-- PRIMARY -->
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeStreetAddress" Text="Primary Office Street Address" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeStreetAddress"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeCityStateZip" Text="City/State/Zip" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeCityStateZip"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeTelephoneNumber"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeFaxNumber" Text="Fax Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeFaxNumber"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeManagerAdministrator" Text="Office Manager/Administrator:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeManagerAdministrator"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeManagerTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeManagerTelephoneNumber"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeManagerFaxNumber" Text="Fax Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeManagerFaxNumber"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeNameTaxIdNumber" Text="Name Affiliated with Tax ID Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeNameTaxIdNumber"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeFederalTaxIdNumber" Text="Federal Tax ID Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeFederalTaxIdNumber"/>
			</div>
		</div>
		<hr />
		<!-- SECONDARY -->
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeStreetAddress" EnableViewState="False"><strong>Secondary</strong> Office Street Address</asp:Label>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeStreetAddress"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeCity" Text="City" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeCity"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeState" Text="State" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeState"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeZip" Text="Zip" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeZip"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeManagerAdministrator" Text="Office Manager/Administrator:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeManagerAdministrator"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeManagerTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeManagerTelephoneNumber"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeManagerFaxNumber" Text="Fax Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeManagerFaxNumber"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeNameTaxIdNumber" Text="Name Affiliated with Tax ID Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeNameTaxIdNumber"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeFederalTaxIdNumber" Text="Federal Tax ID Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeFederalTaxIdNumber"/>
			</div>
		</div>
		<hr />
		<!-- TERTIARY -->
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeStreetAddress" EnableViewState="False"><strong>Tertiary</strong> Office Street Address</asp:Label>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeStreetAddress"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeCity" Text="City" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeCity"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeState" Text="State" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeState"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeZip" Text="Zip" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeZip"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeManagerAdministrator" Text="Office Manager/Administrator:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeManagerAdministrator"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeManagerTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeManagerTelephoneNumber"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeManagerFaxNumber" Text="Fax Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeManagerFaxNumber"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeNameTaxIdNumber" Text="Name Affiliated with Tax ID Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeNameTaxIdNumber"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeFederalTaxIdNumber" Text="Federal Tax ID Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeFederalTaxIdNumber"/>
			</div>
		</div>
	</div>
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
</asp:Content>