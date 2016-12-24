<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResidenciesFellowships.aspx.cs" Inherits="Credentialing.Web.Steps.ResidencesFellowships" MasterPageFile="../Main.Master" %>
<%@ Register Src="~/Usercontrols/RenderAttachments.ascx" TagPrefix="uc" TagName="Attachments" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
	<uc:SidebarProgress runat="server" CurrentStep="6" EnableViewState="false"/>
	<div class="form-block">
		<div class="form-heading">
			<h2><strong>7.</strong> Residencies / Fellowships</h2>
		</div>
		<h1>Coming soon</h1>
		<asp:Panel ID="Panel1" runat="server" Enabled="false" Visible="false">
		<div class="row">
			<div class="col-md-12">
				<p>Include residencies, fellowships, Preceptorship, teaching appointments (indicate whether clinical or academic), and postgraduate education in chronological order, giving name, address, city, ZIP code, and dates. Include <strong>all</strong> programs you attended, whether or not completed.</p>
			</div>
		</div>
		<hr />
		<!-- PRIMARY -->
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxInstitutionFirst" Text="Institution:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxInstitutionFirst"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxProgramDirectorFirst" Text="Program Director:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxProgramDirectorFirst"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingAddressFirst" Text="Mailing Address:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAddressFirst"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxCityFirst" Text="City:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxCityFirst"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxStateFirst" Text="State:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxStateFirst"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxZipFirst" Text="ZIP:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxZipFirst"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTrainingTypeFirst" Text="Type of training (eg. residency, etc.):" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTrainingTypeFirst"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSpecialtyFirst" Text="Specialty:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSpecialtyFirst"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxFromDateFirst" Text="From: (mm/yy)" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxFromDateFirst"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxToDateFirst" Text="To: (mm/yy)" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxToDateFirst"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<span class="label">Did you successfully complete the program?</span>
				<div class="radio-wrap">
					<span class="radio">
						<asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnProgramFirstYes" GroupName="ProgramCompletedFirst" />
						<asp:Label runat="server" AssociatedControlID="rbtnProgramFirstYes" EnableViewState="False">Yes</asp:Label>
					</span>
					<span class="radio">
						<asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnProgramFirstNo" GroupName="ProgramCompletedFirst"/>
						<asp:Label runat="server" AssociatedControlID="rbtnProgramFirstNo" EnableViewState="False">No</asp:Label>
					</span>
				</div>
				<span class="form-description">(If "No", please explain on separate sheet.)</span>
			</div>
		</div>
		<hr />
		<!-- SECONDARY -->
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxInstitutionSecond" Text="Institution:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxInstitutionSecond"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxProgramDirectorSecond" Text="Program Director:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxProgramDirectorSecond"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingAddressSecond" Text="Mailing Address:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAddressSecond"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxCitySecond" Text="City:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxCitySecond"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxStateSecond" Text="State:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxStateSecond"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxZipSecond" Text="ZIP:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxZipSecond"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTrainingTypeSecond" Text="Type of training (eg. residency, etc.):" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTrainingTypeSecond"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSpecialtySecond" Text="Specialty:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSpecialtySecond"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxFromDateSecond" Text="From: (mm/yy)" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxFromDateSecond"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxToDateSecond" Text="To: (mm/yy)" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxToDateSecond"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<span class="label">Did you successfully complete the program?</span>
				<div class="radio-wrap">
					<span class="radio">
						<asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnProgramSecondYes" GroupName="ProgramCompletedSecond" />
						<asp:Label runat="server" AssociatedControlID="rbtnProgramSecondYes" EnableViewState="False">Yes</asp:Label>
					</span>
					<span class="radio">
						<asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnProgramSecondNo" GroupName="ProgramCompletedSecond"/>
						<asp:Label runat="server" AssociatedControlID="rbtnProgramSecondNo" EnableViewState="False">No</asp:Label>
					</span>
				</div>
				<span class="form-description">(If "No", please explain on separate sheet.)</span>
			</div>
		</div>
		<hr />
		<!-- TERTIARY -->
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxInstitutionThird" Text="Institution:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxInstitutionThird"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxProgramDirectorThird" Text="Program Director:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxProgramDirectorThird"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingAddressThird" Text="Mailing Address:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAddressThird"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxCityThird" Text="City:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxCityThird"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxStateThird" Text="State:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxStateThird"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxZipThird" Text="ZIP:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxZipThird"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxTrainingTypeThird" Text="Type of training (eg. residency, etc.):" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTrainingTypeThird"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSpecialtyThird" Text="Specialty:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSpecialtyThird"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxFromDateThird" Text="From: (mm/yy)" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxFromDateThird"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxToDateThird" Text="To: (mm/yy)" EnableViewState="false"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxToDateThird"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<span class="label">Did you successfully complete the program?</span>
				<div class="radio-wrap">
					<span class="radio">
						<asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnProgramThirdYes" GroupName="ProgramCompletedThird" />
						<asp:Label runat="server" AssociatedControlID="rbtnProgramThirdYes" EnableViewState="False">Yes</asp:Label>
					</span>
					<span class="radio">
						<asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnProgramThirdNo" GroupName="ProgramCompletedThird"/>
						<asp:Label runat="server" AssociatedControlID="rbtnProgramThirdNo" EnableViewState="False">No</asp:Label>
					</span>
				</div>
				<span class="form-description">(If "No", please explain on separate sheet.)</span>
			</div>
		</div>
            <asp:FileUpload runat="server" ID="fuResidencies" AllowMultiple="True"/>
            <hr/>
		<uc:Attachments ID="ucAttachments" runat="server" EnableViewState="False"/>
		</asp:Panel>
	</div>
	<asp:Panel ID="Panel2" runat="server" Enabled="false" Visible="false">
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
	</asp:Panel>
</asp:Content>