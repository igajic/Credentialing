<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BoardCertification.aspx.cs" Inherits="Credentialing.Web.Steps.BoardCertification" MasterPageFile="../Main.Master" %>
<%@ Register Src="~/Usercontrols/SidebarProgress.ascx" TagPrefix="uc" TagName="SidebarProgress" %>
<%@ Register Src="~/Usercontrols/RenderAttachments.ascx" TagPrefix="uc" TagName="Attachments" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button" />
    <uc:SidebarProgress runat="server" CurrentStep="8" EnableViewState="false" />
    <div class="form-block">
        <div class="form-heading">
            <h2><strong>8.</strong> BOARD CERTIFICATION</h2>
        </div>
        <div class="row">
            <div class="col-md-12">
                <p>
                    Include certifications by board(s) which are duly organized and recognized by:
                </p>
                <ul>
                    <li>a member board of the American Board of Medical Specialties</li>
                    <li>a member board of the American Osteopathic Association</li>
                    <li>a board or association with an Accreditation Council for Graduate Medical Education or American Osteopathic Association approved postgraduate training that provides complete training in that specialty or subspecialty</li>
                </ul>
            </div>
        </div>
        
		<div class="row">
			<div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryNameIssuingBoard" Text="Name of Issuing Board:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryNameIssuingBoard" ClientIDMode="Static" />
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxPrimarySpecialty" Text="Specialty:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimarySpecialty" ClientIDMode="Static" />
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryDateCertifiedRecertified" Text="Date Certified/Recertified:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryDateCertifiedRecertified" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxPrimaryExpirationDate" Text="Expiration Date (if any):" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxPrimaryExpirationDate" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
        </div>
        <hr/>
        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryNameIssuingBoard" Text="Name of Issuing Board:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryNameIssuingBoard" ClientIDMode="Static" />
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondarySpecialty" Text="Specialty:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondarySpecialty" ClientIDMode="Static" />
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryDateCertifiedRecertified" Text="Date Certified/Recertified:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryDateCertifiedRecertified" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxSecondaryExpirationDate" Text="Expiration Date (if any):" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxSecondaryExpirationDate" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
        </div>
        <hr/>
        <div class="row">
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryNameIssuingBoard" Text="Name of Issuing Board:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryNameIssuingBoard" ClientIDMode="Static" />
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxTertiarySpecialty" Text="Specialty:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiarySpecialty" ClientIDMode="Static" />
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryDateCertifiedRecertified" Text="Date Certified/Recertified:" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryDateCertifiedRecertified" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" AssociatedControlID="tboxTertiaryExpirationDate" Text="Expiration Date (if any):" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxTertiaryExpirationDate" ClientIDMode="Static" CssClass="datepicker-default" />
            </div>
        </div>
        <hr/>
        <div class="row">
            <div class="col-md-6">
                <span class="label">Have you applied for board certification other than those indicated above?</span>
                <div class="radio-wrap">
                    <span class="radio">
                        <asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnYes" GroupName="BoardCert" />
                        <asp:Label runat="server" AssociatedControlID="rbtnYes" EnableViewState="False" Text="Yes" />
                    </span>
                    <span class="radio">
                        <asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnNo" GroupName="BoardCert" />
                        <asp:Label runat="server" AssociatedControlID="rbtnNo" EnableViewState="False" Text="No" />
                    </span>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <asp:Label runat="server" AssociatedControlID="tboxAdditionalListBoardsDates" Text="If so, list board(s) and date(s):" EnableViewState="False" />
                <asp:TextBox runat="server" ID="tboxAdditionalListBoardsDates" ClientIDMode="Static" TextMode="MultiLine" />
            </div>
        </div>
        
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" Text="Attach additional sheets if necessary" CssClass="label" />
				<div class="file-upload">
					<asp:FileUpload ClientIDMode="Static" runat="server" ID="fuAttachments" AllowMultiple="False"/>
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