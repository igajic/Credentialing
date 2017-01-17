<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IdentifyingInformation.aspx.cs" Inherits="Credentialing.Web.Steps.IdentifyingInformation" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed" CssClass="btn btn-green review-button"/>
	<uc:SidebarProgress runat="server" CurrentStep="2" EnableViewState="false"/>

	<div class="form-block">
		<div class="row">
			<div class="col-md-5">
				<asp:Label runat="server" AssociatedControlID="tboxLastName" Text="Last Name:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxLastName"/>
			</div>
			<div class="col-md-4">
				<asp:Label runat="server" AssociatedControlID="tboxFirstName" Text="First:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxFirstName"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxMiddleName" Text="Middle:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMiddleName"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-12">
				<asp:Label runat="server" AssociatedControlID="tboxOtherKnownNames" Text="Is there any other name under which you have been known? Name(s):" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxOtherKnownNames"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-12">
				<asp:Label runat="server" AssociatedControlID="tboxHomeMailingAddress" Text="Home Mailing Address:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxHomeMailingAddress"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-5">
				<asp:Label runat="server" AssociatedControlID="tboxCity" Text="City:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxCity"/>
			</div>
			<div class="col-md-4">
				<asp:Label runat="server" AssociatedControlID="tboxState" Text="State:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxState"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxZip" Text="ZIP:" EnableViewState="False"/>
				<asp:TextBox  ClientIDMode="Static" runat="server" ID="tboxZip"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxHomeTelephoneNumber" Text="Home Telephone Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxHomeTelephoneNumber"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxHomeFaxNumber" Text="Home Fax Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxHomeFaxNumber"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxEmailAddress" Text="E-Mail Address:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxEmailAddress"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxPagerNumber" Text="Pager Number:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPagerNumber"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxBirthDate" Text="Birth Date:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxBirthDate" placeholder="mm/dd/yyyy" CssClass="datepicker datepicker-default"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxBirthPlace" Text="Birth Place (City/State/Country):" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxBirthPlace"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6 padd-top">
				<asp:Label runat="server" AssociatedControlID="tboxSocialSecurityNumber" Text="Social Security #:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSocialSecurityNumber" EnableViewState="False"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" Text="Citizenship (If not a United States citizen, please include copy of Alien Registration Card)" CssClass="label" />
				<div class="file-upload">
					<asp:FileUpload ClientIDMode="Static" runat="server" ID="fuAlienRegistrationCard"/>
					<span class="temp-filename"></span>
					<span class="upload-file-btn"><i class="ico"></i></span>
				</div>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<span class="label">Gender<sup>2</sup>:</span>
				<div class="radio-wrap">
					<span class="radio">
						<asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnMale" GroupName="Gender" Checked="true" />
						<asp:Label runat="server" AssociatedControlID="rbtnMale" EnableViewState="False">Male</asp:Label>
					</span>
					<span class="radio">
						<asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnFemale" GroupName="Gender"/>
						<asp:Label runat="server" AssociatedControlID="rbtnFemale" EnableViewState="False">Female</asp:Label>
					</span>
				</div>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxRaceEthnicity" EnableViewState="False">Race/Ethnicity<sup>2</sup> (voluntary):</asp:Label>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxRaceEthnicity" />
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSpecialty" Text="Specialty:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSpecialty"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxSubspeciality" Text="Subspecialties:" EnableViewState="False"/>
				<asp:TextBox runat="server" ClientIDMode="Static" ID="tboxSubspeciality"/>
			</div>
		</div>
		<hr />
		<div class="row attachments">
			<div class="col-md-6">
				<span class="label">Attachment:</span>
				<asp:HyperLink runat="server" ID="hlAttachment" Visible="False"/>
			</div>
		</div>
		<hr />

		<div class="row">
			<div class="footnotes col-md-12">
				<p>
					<sup>1</sup> As used in the Information Release/Acknowledgments Section of this application, the term "this Healthcare Organization" shall refer to the entity to which this application is submitted as identified above.
				</p>
				<p>
					<sup>2</sup> This information will be used for consumer information purposes only.
				</p>
			</div>
		</div>
	</div>
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
</asp:Content>