﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrentAffiliations.aspx.cs" Inherits="Credentialing.Web.Steps.CurrentAffiliations" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<%@ Register TagPrefix="uc" TagName="Attachments" Src="~/Usercontrols/RenderAttachments.ascx" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
    <uc:SidebarProgress ID="SidebarProgress1" runat="server" CurrentStep="13" EnableViewState="false"/>
        
    <div class="form-block">

		<div class="row">
			<div class="col-md-12">
                <p>Please list in reverse chronological order (with the current affiliation{s} first) all institutions where you have current affiliations (A) and have had previous hospital privileges (B) during the past ten years. This includes hospitals, surgery centers, institutions, corporations, military assignments, or government agencies.</p>
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-12">
                <h2>A. Current Affiliations</h2>
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentPrimaryAdmittingHospital" Text="Name and Mailing Address of Primary Admitting Hospital:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentPrimaryAdmittingHospital" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 md-margin-bot padd-top-tablet">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentPrimaryCity" Text="City:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentPrimaryCity" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentPrimaryState" Text="State:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentPrimaryState" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentPrimaryZip" Text="ZIP:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentPrimaryZip" ClientIDMode="Static" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentPrimaryDepartmentStatus" Text="Department/Status (active, provisional, courtesy, etc.):" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentPrimaryDepartmentStatus" ClientIDMode="Static" />
            </div>
            <div class="col-md-6 padd-top-tablet">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentPrimaryAppointmentDate" Text="Appointment Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentPrimaryAppointmentDate" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
        </div>

        <hr />

        <div class="row">
            <div class="col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentSecondaryAdmittingHospital" Text="Name and Mailing Address of Other Admitting Hospital:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentSecondaryAdmittingHospital" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 md-margin-bot padd-top-tablet">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentSecondaryCity" Text="City:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentSecondaryCity" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentSecondaryState" Text="State:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentSecondaryState" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentSecondaryZip" Text="ZIP:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentSecondaryZip" ClientIDMode="Static" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentSecondaryDepartmentStatus" Text="Department/Status:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentSecondaryDepartmentStatus" ClientIDMode="Static" />
            </div>
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentSecondaryAppointmentDate" Text="Appointment Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentSecondaryAppointmentDate" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
        </div>

        <hr />
            
        <div class="row">
            <div class="col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentTertiaryAdmittingHospital" Text="Name and Mailing Address of Other Admitting Hospital:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentTertiaryAdmittingHospital" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 md-margin-bot padd-top-tablet">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentTertiaryCity" Text="City:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentTertiaryCity" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentTertiaryState" Text="State:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentTertiaryState" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentTertiaryZip" Text="ZIP:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentTertiaryZip" ClientIDMode="Static" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentTertiaryDepartmentStatus" Text="Department/Status:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentTertiaryDepartmentStatus" ClientIDMode="Static" />
            </div>
            <div class="col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxCurrentTertiaryAppointmentDate" Text="Appointment Date:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxCurrentTertiaryAppointmentDate" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
        </div>
        <span class="label">If you do not have hospital privileges, please explain on Addendum A</span>
        <hr />
            
        <div class="row">
            <div class="col-md-12">
                <h2>B. Previous affiliations During Last Five Years</h2>
            </div>
        </div>                    
            
        <div class="row">
            <div class="col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousPrimaryAdmittingHospital" Text="Name and Mailing Address of Other Hospital/Institution:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousPrimaryAdmittingHospital" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 md-margin-bot padd-top-tablet">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousPrimaryCity" Text="City:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousPrimaryCity" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousPrimaryState" Text="State:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousPrimaryState" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousPrimaryZip" Text="ZIP:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousPrimaryZip" ClientIDMode="Static" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousPrimaryFrom" Text="From:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousPrimaryFrom" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousPrimaryTo" Text="To:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousPrimaryTo" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousPrimaryReasonLeaving" Text="Reason for Leaving:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousPrimaryReasonLeaving" ClientIDMode="Static" />
            </div>
        </div>

        <hr />

        <div class="row">
            <div class="col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousSecondaryAdmittingHospital" Text="Name and Mailing Address of Other Hospital/Institution:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousSecondaryAdmittingHospital" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 md-margin-bot padd-top-tablet">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousSecondaryCity" Text="City:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousSecondaryCity" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousSecondaryState" Text="State:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousSecondaryState" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousSecondaryZip" Text="ZIP:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousSecondaryZip" ClientIDMode="Static" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousSecondaryFrom" Text="From:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousSecondaryFrom" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousSecondaryTo" Text="To:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousSecondaryTo" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousSecondaryReasonLeaving" Text="Reason for Leaving:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousSecondaryReasonLeaving" ClientIDMode="Static" />
            </div>
        </div>

        <hr />
            
        <div class="row">
            <div class="col-md-6 md-margin-bot">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousTertiaryAdmittingHospital" Text="Name and Mailing Address of Other Hospital/Institution:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousTertiaryAdmittingHospital" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6 md-margin-bot padd-top-tablet">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousTertiaryCity" Text="City:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousTertiaryCity" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousTertiaryState" Text="State:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousTertiaryState" ClientIDMode="Static" />
            </div>
            <div class="col-lg-2 col-md-6">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousTertiaryZip" Text="ZIP:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousTertiaryZip" ClientIDMode="Static" />
            </div>
        </div>
            
        <div class="row">
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousTertiaryFrom" Text="From:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousTertiaryFrom" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousTertiaryTo" Text="To:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousTertiaryTo" ClientIDMode="Static" placeholder="mm/yy" CssClass="datepicker-monthly" />
            </div>
            <div class="col-md-4">
                <asp:Label runat="server" AssociatedControlID="tboxPreviousTertiaryReasonLeaving" Text="Reason for Leaving:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPreviousTertiaryReasonLeaving" ClientIDMode="Static" />
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
</asp:Content>