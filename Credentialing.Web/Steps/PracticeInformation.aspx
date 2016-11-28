﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PracticeInformation.aspx.cs" Inherits="Credentialing.Web.Steps.PracticeInformation" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>PRACTICE INFORMATION</h1>

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

    <asp:Label runat="server" AssociatedControlID="tboxSecondaryOfficeCityStateZip" Text="City/State/Zip" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSecondaryOfficeCityStateZip"/>

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

    <asp:Label runat="server" AssociatedControlID="tboxTertiaryOfficeCityStateZip" Text="City/State/Zip" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTertiaryOfficeCityStateZip"/>

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
</asp:Content>