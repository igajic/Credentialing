﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkHistory.aspx.cs" Inherits="Credentialing.Web.Steps.WorkHistory" MasterPageFile="../Main.Master" %>
<%@ Register Src="~/Usercontrols/RenderAttachments.ascx" TagPrefix="uc" TagName="Attachments" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
	<uc:SidebarProgress runat="server" CurrentStep="15" EnableViewState="false"/>
        
    <div class="form-block">
		<div class="row">
			<div class="col-md-12">
                <p>Chronologically list all work history activities since completion of postgraduate training (use extra sheets if necessary). This information must be complete. A curriculum vitae is sufficient provided it is current and contains all information requested below. Please explain any gaps in professional work history in designated area at end of this section. Work History MUST INCLUDE practice location (address).</p>
            </div>
        </div>
            
        <div class="row">
            <div class="col-lg-4 col-md-6 padd-top-desktop md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryNamePracticeEmployer" Text="Current Practice:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryNamePracticeEmployer" ClientIDMode="Static" />
            </div>
            <div class="col-lg-4 col-md-6 padd-top-desktop md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryContactName" Text="Contact Name:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryContactName" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryTelephoneNumber" Text="Telephone Number:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryTelephoneNumber" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 padd-top-desktop">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryFaxNumber" Text="Fax Number:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryFaxNumber" ClientIDMode="Static" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryPracticeAddress" Text="Practice Address:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryPracticeAddress" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryCity" Text="City:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryCity" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryZip" Text="Zip:" EnableViewState="false" />
                <asp:TextBox runat="server" ID="tboxPrimaryZip" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryState" Text="State" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryState" ClientIDMode="Static" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryStartDate" Text="Start Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryStartDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryEndDate" Text="End Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryEndDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
        </div>

            
        <hr/>
            
        <div class="row">
            <div class="col-lg-4 col-md-6 padd-top-desktop md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryNamePracticeEmployer" Text="Name of Practice/Employer:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryNamePracticeEmployer" ClientIDMode="Static" />
            </div>
            <div class="col-lg-4 col-md-6 padd-top-desktop md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryContactName" Text="Contact Name:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryContactName" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryTelephoneNumber" Text="Telephone Number:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryTelephoneNumber" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 padd-top-desktop">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryFaxNumber" Text="Fax Number:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryFaxNumber" ClientIDMode="Static" />
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryPracticeAddress" Text="Practice Address:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryPracticeAddress" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryCity" Text="City:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryCity" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryZip" Text="Zip:" EnableViewState="false" />
                <asp:TextBox runat="server" ID="tboxSecondaryZip" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryState" Text="State:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryState" ClientIDMode="Static" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryStartDate" Text="Start Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryStartDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryEndDate" Text="End Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryEndDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
        </div>

        <hr/>
            
        <div class="row">
            <div class="col-lg-4 col-md-6 padd-top-desktop md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryNamePracticeEmployer" Text="Name of Practice/Employer:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryNamePracticeEmployer" ClientIDMode="Static" />
            </div>
            <div class="col-lg-4 col-md-6 padd-top-desktop md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryContactName" Text="Contact Name:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryContactName" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryTelephoneNumber" Text="Telephone Number:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryTelephoneNumber" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 padd-top-desktop">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryFaxNumber" Text="Fax Number:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryFaxNumber" ClientIDMode="Static" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryPracticeAddress" Text="Practice Address:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryPracticeAddress" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryCity" Text="City:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryCity" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryZip" Text="Zip:" EnableViewState="false" />
                <asp:TextBox runat="server" ID="tboxTertiaryZip" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryState" Text="State:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryState" ClientIDMode="Static" />
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryStartDate" Text="Start Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryStartDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryEndDate" Text="End Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryEndDate" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly"/>
            </div>
        </div>

        <hr />
            
        <div class="row">
            <div class="col-md-12">
                <h4>EXPLANATION FOR BREAKS IN WORK HISTORY</h4>
                <h5>Explanations must be given for breaks of six months or more)</h5>
                <asp:TextBox runat="server" ID="tboxExplanation" TextMode="MultiLine" ClientIDMode="Static" />
            </div>
        </div>

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
</asp:Content>