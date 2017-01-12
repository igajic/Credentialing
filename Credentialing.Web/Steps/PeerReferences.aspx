<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PeerReferences.aspx.cs" Inherits="Credentialing.Web.Steps.PeerReferences" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>XIV. PEER REFERENCES<</h1>
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>
    <asp:Panel ID="Panel1" runat="server" Visible="False">
	    <asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
	    <uc:SidebarProgress runat="server" CurrentStep="14" EnableViewState="false"/>
        
        <div class="form-block">
            <div class="form-heading">
                <h2><strong>14.</strong>PEER REFERENCES</h2>
                <p>List three professional references, preferably from your specialty area, not including relatives, current partners or associates in practice. If possible, include at least one member from the Medical Staff of each facility at which you have privileges. NOTE: References must be from individuals who are directly familiar with your work, either via direct clinical observation or through close working relations.</p>
            </div>
            
            <div class="row">
                <div class="col-md-4">
                    <asp:Label runat="server" AssociatedControlID="tboxPrimaryNameReference" Text="Name of Reference:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxPrimaryNameReference" ClientIDMode="Static" />
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" AssociatedControlID="tboxPrimarySpecialty" Text="Specialty:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxPrimarySpecialty" ClientIDMode="Static" />
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" AssociatedControlID="tboxPrimaryTelephoneNumber" Text="Telephone Number:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxPrimaryTelephoneNumber" ClientIDMode="Static" />
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxPrimaryMailingAddress" Text="Mailing Address:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxPrimaryMailingAddress" ClientIDMode="Static" />
                </div>
                <div class="col-md-2">
                    <asp:Label runat="server" AssociatedControlID="tboxPrimaryCity" Text="City:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxPrimaryCity" ClientIDMode="Static" />
                </div>
                <div class="col-md-2">
                    <asp:Label runat="server" AssociatedControlID="tboxPrimaryState" Text="State:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxPrimaryState" ClientIDMode="Static" />
                </div>
                <div class="col-md-2">
                    <asp:Label runat="server" AssociatedControlID="tboxPrimaryZip" Text="ZIP:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxPrimaryZip" ClientIDMode="Static" />
                </div>
            </div>
            
            <hr/>
            
            <div class="row">
                <div class="col-md-4">
                    <asp:Label runat="server" AssociatedControlID="tboxSecondaryNameReference" Text="Name of Reference:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxSecondaryNameReference" ClientIDMode="Static" />
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" AssociatedControlID="tboxSecondarySpecialty" Text="Specialty:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxSecondarySpecialty" ClientIDMode="Static" />
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" AssociatedControlID="tboxSecondaryTelephoneNumber" Text="Telephone Number:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxSecondaryTelephoneNumber" ClientIDMode="Static" />
                </div>
            </div>
            
            <div class="row">
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxSecondaryMailingAddress" Text="Mailing Address:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxSecondaryMailingAddress" ClientIDMode="Static" />
                </div>
                <div class="col-md-2">
                    <asp:Label runat="server" AssociatedControlID="tboxSecondaryCity" Text="City:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxSecondaryCity" ClientIDMode="Static" />
                </div>
                <div class="col-md-2">
                    <asp:Label runat="server" AssociatedControlID="tboxSecondaryState" Text="State:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxSecondaryState" ClientIDMode="Static" />
                </div>
                <div class="col-md-2">
                    <asp:Label runat="server" AssociatedControlID="tboxSecondaryZip" Text="ZIP:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxSecondaryZip" ClientIDMode="Static" />
                </div>
            </div>
            
            <hr/>
            
            <div class="row">
                <div class="col-md-4">
                    <asp:Label runat="server" AssociatedControlID="tboxTertiaryNameReference" Text="Name of Reference:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxTertiaryNameReference" ClientIDMode="Static" />
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" AssociatedControlID="tboxTertiarySpecialty" Text="Specialty:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxTertiarySpecialty" ClientIDMode="Static" />
                </div>
                <div class="col-md-4">
                    <asp:Label runat="server" AssociatedControlID="tboxTertiaryTelephoneNumber" Text="Telephone Number:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxTertiaryTelephoneNumber" ClientIDMode="Static" />
                </div>
            </div>
            
            <div class="row">
                <div class="col-md-6">
                    <asp:Label runat="server" AssociatedControlID="tboxTertiaryMailingAddress" Text="Mailing Address:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxTertiaryMailingAddress" ClientIDMode="Static" />
                </div>
                <div class="col-md-2">
                    <asp:Label runat="server" AssociatedControlID="tboxTertiaryCity" Text="City:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxTertiaryCity" ClientIDMode="Static" />
                </div>
                <div class="col-md-2">
                    <asp:Label runat="server" AssociatedControlID="tboxTertiaryState" Text="State:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxTertiaryState" ClientIDMode="Static" />
                </div>
                <div class="col-md-2">
                    <asp:Label runat="server" AssociatedControlID="tboxTertiaryZip" Text="ZIP:" EnableViewState="False" />
                    <asp:TextBox runat="server" ID="tboxTertiaryZip" ClientIDMode="Static" />
                </div>
            </div>
        </div>
        <div class="form-actions">
            <asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
            <asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
        </div>
    </asp:Panel>
</asp:Content>