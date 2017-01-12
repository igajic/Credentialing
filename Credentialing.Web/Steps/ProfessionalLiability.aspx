<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfessionalLiability.aspx.cs" Inherits="Credentialing.Web.Steps.ProfessionalLiability" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<%@ Register TagPrefix="uc" TagName="Attachments" Src="~/Usercontrols/RenderAttachments.ascx" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
	<uc:SidebarProgress runat="server" CurrentStep="12" EnableViewState="false"/>
        
    <div class="form-block">
        <div class="form-heading">
            <h2><strong>12.</strong>PROFESSIONAL LIABILITY</h2>
        </div>
            
        <div class="row">
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentInsuranceCarrier" Text="Current Insurance Carrier:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxCurrentInsuranceCarrier" ClientIDMode="Static"/>
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentPolicyNumber" Text="Policy Number:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxCurrentPolicyNumber" ClientIDMode="Static"/>
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxInitialEffectiveDate" Text="Initial Effective Date:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxInitialEffectiveDate" ClientIDMode="Static" CssClass="datepicker-default"/>
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentMailingNumber" Text="Mailing Address:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxCurrentMailingNumber" ClientIDMode="Static"/>
            </div>
            <div class="col-md-2">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentCity" Text="City:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxCurrentCity" ClientIDMode="Static"/>
            </div>
            <div class="col-md-2">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentState" Text="State:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxCurrentState" ClientIDMode="Static"/>
            </div>
            <div class="col-md-2">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentZip" Text="ZIP:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxCurrentZip" ClientIDMode="Static"/>
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentPerClaimAmount" Text="Per Claim Amount $" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxCurrentPerClaimAmount" ClientIDMode="Static"/>
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentAggregateAmount" Text="Aggregate Amount: $" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxCurrentAggregateAmount" ClientIDMode="Static"/>
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentExpirationDate" Text="Expiration Date:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxCurrentExpirationDate" ClientIDMode="Static" CssClass="datepicker-default"/>
            </div>
        </div>
        
        <div class="row">
            <div class="col-md-6">
                <span class="label">Please explain any surcharges to your professional liability coverage on a separate sheet</span>
                    
                <span class="label">Please list all of you professional liability cariers within the past FIVE years, other than the one listed above</span>
            </div>
        </div>
        
        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFirstPolicyCarrierName" Text="Name of Carrier:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFirstPolicyCarrierName" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFirstPolicyNumber" Text="Policy Number:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFirstPolicyNumber" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFirstFromDate" Text="From:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFirstFromDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFirstToDate" Text="To:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFirstToDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFirstMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFirstMailingAddress" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFirstCity" Text="City:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFirstCity" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFirstState" Text="State:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFirstState" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFirstZip" Text="ZIP:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFirstZip" ClientIDMode="Static"/>
            </div>
        </div>
        
        <hr/>
            
        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondPolicyCarrierName" Text="Name of Carrier:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxSecondPolicyCarrierName" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondPolicyNumber" Text="Policy #:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxSecondPolicyNumber" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondFromDate" Text="From:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxSecondFromDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondToDate" Text="To:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxSecondToDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxSecondMailingAddress" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondCity" Text="City:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxSecondCity" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondState" Text="State:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxSecondState" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondZip" Text="ZIP:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxSecondZip" ClientIDMode="Static"/>
            </div>
        </div>
            
        <hr/>
        
        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxThirdPolicyCarrierName" Text="Name of Carrier:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxThirdPolicyCarrierName" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxThirdPolicyNumber" Text="Policy Number:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxThirdPolicyNumber" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxThirdFromDate" Text="From:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxThirdFromDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxThirdToDate" Text="To:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxThirdToDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
        </div>

        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxThirdMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxThirdMailingAddress" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxThirdCity" Text="City:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxThirdCity" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxThirdState" Text="State:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxThirdState" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxThirdZip" Text="ZIP:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxThirdZip" ClientIDMode="Static"/>
            </div>
        </div>
        
        <hr/>
        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFourthPolicyCarrierName" Text="Name of Carrier:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFourthPolicyCarrierName" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFourthPolicyNumber" Text="Policy Number:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFourthPolicyNumber" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFourthFromDate" Text="From:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFourthFromDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFourthToDate" Text="To:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFourthToDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFourthMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFourthMailingAddress" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFourthCity" Text="City:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFourthCity" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFourthState" Text="State:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFourthState" ClientIDMode="Static"/>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxFourthZip" Text="ZIP:" EnableViewState="False"/>
                <asp:TextBox runat="server" ID="tboxFourthZip" ClientIDMode="Static"/>
            </div>
        </div>
        
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" Text="Attach additional sheets if necessary" CssClass="label" />
				<div class="file-upload">
					<asp:FileUpload ClientIDMode="Static" runat="server" ID="fuAttachment" AllowMultiple="False"/>
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
</asp:Content>