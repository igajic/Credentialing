<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PracticeInformation.aspx.cs" Inherits="Credentialing.Web.Steps.PracticeInformation" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<div class="form-block">
		<div class="form-heading">
			<h2><strong>3.</strong> Practice information</h2>
		</div>
	</div>

	<asp:Label runat="server" AssociatedControlID="tboxPracticeName" Text="Practice Name (if applicable)" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPracticeName"/>

	<asp:Label runat="server" AssociatedControlID="tboxDepartmentName" Text="Department Name (If Hospital Based)" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDepartmentName"/>
	<!-- PRIMARY -->

	<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeStreetAddress" Text="Primary Office Street Address" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeStreetAddress"/>

	<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeCityStateZip" Text="City/State/Zip" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeCityStateZip"/>

	<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeTelephoneNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeFaxNumber" Text="Fax Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeFaxNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeManagerAdministrator" Text="Office Manager/Administrator:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeManagerAdministrator"/>

	<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeManagerTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeManagerTelephoneNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeManagerFaxNumber" Text="Fax Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeManagerFaxNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeNameTaxIdNumber" Text="Name Affiliated with Tax ID Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeNameTaxIdNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxPrimaryOfficeFederalTaxIdNumber" Text="Federal Tax ID Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPrimaryOfficeFederalTaxIdNumber"/>
	
	
	<!-- SECONDARY -->
	
	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeStreetAddress" EnableViewState="False"><strong>Secondary</strong> Office Street Address</asp:Label>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeStreetAddress"/>

	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeCity" Text="City" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeCity"/>
	
	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeState" Text="State" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeState"/>
	
	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeZip" Text="Zip" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeZip"/>

	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeTelephoneNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeManagerAdministrator" Text="Office Manager/Administrator:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeManagerAdministrator"/>

	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeManagerTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeManagerTelephoneNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeManagerFaxNumber" Text="Fax Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeManagerFaxNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeNameTaxIdNumber" Text="Name Affiliated with Tax ID Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeNameTaxIdNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeFederalTaxIdNumber" Text="Federal Tax ID Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeFederalTaxIdNumber"/>
	
	<!-- TERTIARY -->
	<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeStreetAddress" EnableViewState="False"><strong>Tertiary</strong> Office Street Address</asp:Label>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeStreetAddress"/>

	<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeCity" Text="City" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeCity"/>
	
	<asp:Label ID="Label1" runat="server" AssociatedControlID="tboxSecondaryOfficeState" Text="State" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeState"/>
	
	<asp:Label ID="Label2" runat="server" AssociatedControlID="tboxSecondaryOfficeZip" Text="Zip" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeZip"/>

	<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeTelephoneNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeManagerAdministrator" Text="Office Manager/Administrator:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeManagerAdministrator"/>

	<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeManagerTelephoneNumber" Text="Telephone Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeManagerTelephoneNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeManagerFaxNumber" Text="Fax Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeManagerFaxNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeNameTaxIdNumber" Text="Name Affiliated with Tax ID Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeNameTaxIdNumber"/>

	<asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeFederalTaxIdNumber" Text="Federal Tax ID Number:" EnableViewState="False"/>
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeFederalTaxIdNumber"/>
	
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
</asp:Content>