<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicalProfessionalLicensureRegistrations.aspx.cs" Inherits="Credentialing.Web.Steps.MedicalProfessionalLicensureRegistrations" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>X. MEDICAL/PROFESSIONAL LICENSURE/REGISTRATIONS</h1>
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>
    <asp:Panel runat="server" Visible="False">
        <asp:Label runat="server" AssociatedControlID="tboxPrimaryStateMedicalLicenseNumber" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimaryStateMedicalLicenseNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxLicensureState" Text="State of licensure:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxLicensureState" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxLicensureState" Text="Issue Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxIssueDate" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryStateMedicalLicenseExpirationDate" Text="Expiration DAte:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimaryStateMedicalLicenseExpirationDate" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxDrugAdministrationNumber" Text="Drug Enforcement Administration (DEA) Registration Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxDrugAdministrationNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxDrugAdministrationExpirationDate" Text="Expiration Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxDrugAdministrationExpirationDate" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxStateControlledSubstancesCertificate" Text="State Controlled Dangerous Substances Certificate (CDS)(if applicable)" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxStateControlledSubstancesCertificate" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxStateControlledSubstancesCertificateExpirationDate" Text="Expiration Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxStateControlledSubstancesCertificateExpirationDate" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxECFMGNumber" Text="ECFMG Number (applicable to foreign medical graduates)" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxECFMGNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxECFMGNumberIssueDate" Text="Date Issued:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxECFMGNumberIssueDate" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxMedicareNationalPhysicianIdentifier" Text="Medicare UPIN/National Physician Identifier (NPI)" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxMedicareNationalPhysicianIdentifier" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxMedicaidNumber" Text="Medicaid Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxMedicaidNumber" ClientIDMode="Static"/>
        
        
        <asp:FileUpload runat="server" ID="fuAttachments" AllowMultiple="True"/>
        
        
	    <div class="form-actions">
		    <asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		    <asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	    </div>

    </asp:Panel>
</asp:Content>