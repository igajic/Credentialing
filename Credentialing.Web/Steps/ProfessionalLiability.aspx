<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfessionalLiability.aspx.cs" Inherits="Credentialing.Web.Steps.ProfessionalLiability" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>XII. PROFESSIONAL LIABILITY</h1>
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>

    <asp:Panel runat="server" Visible="False">
	    <asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
	    <uc:SidebarProgress runat="server" CurrentStep="11" EnableViewState="false"/>

        <asp:Label runat="server" AssociatedControlID="tboxCurrentInsuranceCarrier" Text="Current Insurance Carrier:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxCurrentInsuranceCarrier" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxCurrentPolicyNumber" Text="Policy Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxCurrentPolicyNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxInitialEffectiveDate" Text="Initial Effective Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxInitialEffectiveDate" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxCurrentMailingNumber" Text="Mailing Address:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxCurrentMailingNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxCurrentCity" Text="City:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxCurrentCity" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxCurrentState" Text="State:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxCurrentState" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxCurrentZip" Text="ZIP:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxCurrentZip" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxCurrentPerClaimAmount" Text="Per Claim Amount $" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxCurrentPerClaimAmount" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxCurrentAggregateAmount" Text="Aggregate Amount: $" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxCurrentAggregateAmount" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxCurrentExpirationDate" Text="Expiration Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxCurrentExpirationDate" ClientIDMode="Static"/>
        
        
        <span>Please explain any surcharges to your professional liability coverage on a separate sheet</span>
        
        <h5>Please list all of you professional liability cariers within the past FIVE years, other than the one listed above</h5>

        <asp:Label runat="server" AssociatedControlID="tboxFirstPolicyCarrierName" Text="Name of Carrier:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFirstPolicyCarrierName" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFirstPolicyNumber" Text="Policy Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFirstPolicyNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFirstFromDate" Text="From:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFirstFromDate" ClientIDMode="Static" placeholder="mm/yy"/>

        <asp:Label runat="server" AssociatedControlID="tboxFirstToDate" Text="To:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFirstToDate" ClientIDMode="Static" placeholder="mm/yy"/>

        <asp:Label runat="server" AssociatedControlID="tboxFirstMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFirstMailingAddress" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFirstCity" Text="City:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFirstCity" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFirstState" Text="State:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFirstState" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFirstZip" Text="ZIP:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFirstZip" ClientIDMode="Static"/>
        
        
        
        <asp:Label runat="server" AssociatedControlID="tboxSecondPolicyCarrierName" Text="Name of Carrier:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondPolicyCarrierName" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondPolicyNumber" Text="Policy #:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondPolicyNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondFromDate" Text="From:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondFromDate" ClientIDMode="Static" placeholder="mm/yy"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondToDate" Text="To:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondToDate" ClientIDMode="Static" placeholder="mm/yy"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondMailingAddress" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondCity" Text="City:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondCity" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondState" Text="State:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondState" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondZip" Text="ZIP:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondZip" ClientIDMode="Static"/>
        
        
        <asp:Label runat="server" AssociatedControlID="tboxThirdPolicyCarrierName" Text="Name of Carrier:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxThirdPolicyCarrierName" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxThirdPolicyNumber" Text="Policy Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxThirdPolicyNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxThirdFromDate" Text="From:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxThirdFromDate" ClientIDMode="Static" placeholder="mm/yy"/>

        <asp:Label runat="server" AssociatedControlID="tboxThirdToDate" Text="To:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxThirdToDate" ClientIDMode="Static" placeholder="mm/yy"/>

        <asp:Label runat="server" AssociatedControlID="tboxThirdMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxThirdMailingAddress" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxThirdCity" Text="City:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxThirdCity" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxThirdState" Text="State:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxThirdState" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxThirdZip" Text="ZIP:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxThirdZip" ClientIDMode="Static"/>
        
        
        
        <asp:Label runat="server" AssociatedControlID="tboxFourthPolicyCarrierName" Text="Name of Carrier:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFourthPolicyCarrierName" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFourthPolicyNumber" Text="Policy Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFourthPolicyNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFourthFromDate" Text="From:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFourthFromDate" ClientIDMode="Static" placeholder="mm/yy"/>

        <asp:Label runat="server" AssociatedControlID="tboxFourthToDate" Text="To:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFourthToDate" ClientIDMode="Static" placeholder="mm/yy"/>

        <asp:Label runat="server" AssociatedControlID="tboxFourthMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFourthMailingAddress" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFourthCity" Text="City:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFourthCity" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFourthState" Text="State:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFourthState" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxFourthZip" Text="ZIP:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxFourthZip" ClientIDMode="Static"/>
        
        
        <asp:FileUpload runat="server" ID="fuAttachment"/>

    </asp:Panel>
    
    

	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
</asp:Content>