<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicalProfessionalLicensureRegistrations.aspx.cs" Inherits="Credentialing.Web.Steps.MedicalProfessionalLicensureRegistrations" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<%@ Register Src="~/Usercontrols/RenderAttachments.ascx" TagPrefix="uc" TagName="Attachments" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>X. MEDICAL/PROFESSIONAL LICENSURE/REGISTRATIONS (Remember to attach copies of documents) </h1>
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>
    <asp:Panel runat="server" Visible="False">
    
	    <asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
        <uc:SidebarProgress runat="server" CurrentStep="9" EnableViewState="false"/>
        
        <div class="form-block">
            <div class="form-heading">
                <h2><strong>10.</strong>MEDICAL/PROFESSIONAL LICENSURE/REGISTRATIONS</h2>
            </div>
            
            <div class="row">
                <div class="col-md-3">
                    <asp:Label runat="server" AssociatedControlID="tboxPrimaryStateMedicalLicenseNumber" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxPrimaryStateMedicalLicenseNumber" ClientIDMode="Static"/>
                </div>
                
                <div class="col-md-3">
                    <asp:Label runat="server" AssociatedControlID="tboxLicensureState" Text="State of licensure:" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxLicensureState" ClientIDMode="Static"/>
                </div>
                
                <div class="col-md-3">
                    <asp:Label runat="server" AssociatedControlID="tboxLicensureState" Text="Issue Date:" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxIssueDate" ClientIDMode="Static"/>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" AssociatedControlID="tboxPrimaryStateMedicalLicenseExpirationDate" Text="Expiration DAte:" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxPrimaryStateMedicalLicenseExpirationDate" ClientIDMode="Static"/>
                </div>
            </div>
            
            <div class="row">
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxDrugAdministrationNumber" Text="Drug Enforcement Administration (DEA) Registration Number:" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxDrugAdministrationNumber" ClientIDMode="Static"/>
                </div>
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxDrugAdministrationExpirationDate" Text="Expiration Date:" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxDrugAdministrationExpirationDate" ClientIDMode="Static"/>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxStateControlledSubstancesCertificate" Text="State Controlled Dangerous Substances Certificate (CDS)(if applicable)" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxStateControlledSubstancesCertificate" ClientIDMode="Static"/>
                </div>
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxStateControlledSubstancesCertificateExpirationDate" Text="Expiration Date:" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxStateControlledSubstancesCertificateExpirationDate" ClientIDMode="Static"/>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxECFMGNumber" Text="ECFMG Number (applicable to foreign medical graduates)" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxECFMGNumber" ClientIDMode="Static"/>
                </div>
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxECFMGNumberIssueDate" Text="Date Issued:" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxECFMGNumberIssueDate" ClientIDMode="Static"/>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxMedicareNationalPhysicianIdentifier" Text="Medicare UPIN/National Physician Identifier (NPI)" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxMedicareNationalPhysicianIdentifier" ClientIDMode="Static"/>
                </div>
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxMedicaidNumber" Text="Medicaid Number:" EnableViewState="False"/>
                    <asp:TextBox runat="server" ID="tboxMedicaidNumber" ClientIDMode="Static"/>
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

    </asp:Panel>
</asp:Content>