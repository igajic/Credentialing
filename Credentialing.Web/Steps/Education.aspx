<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Education.aspx.cs" Inherits="Credentialing.Web.Steps.Education"  MasterPageFile="../Main.Master"%>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <uc:SidebarProgress runat="server" CurrentStep="4" EnableViewState="false"/>
	<div class="form-block">
		<div class="form-heading">
			<h2><strong>4.</strong> Education</h2>
		</div>
		<div class="row">
		    
		    <asp:LinkButton ID="lbReview" runat="server" Text="Mark as reviewed"/>

			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxCollegeUniversityName" Text="College or University Name:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxCollegeUniversityName"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxDegreeReceived" Text="Degree Received:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDegreeReceived"/>
			</div>
			<div class="col-md-3">
				<asp:Label runat="server" AssociatedControlID="tboxDateOfGraduation" Text="Date of Graduation (mm/yy)" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDateOfGraduation" placeholder="mm/yy" CssClass="datepicker datepicker-monthly"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAddress"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingCity" Text="City:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingCity"/>
			</div>
		</div>
		<div class="row">
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingState" Text="State:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingState"/>
			</div>
			<div class="col-md-6">
				<asp:Label runat="server" AssociatedControlID="tboxMailingZip" Text="ZIP:" EnableViewState="False"/>
				<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingZip" />
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
        
        <asp:Repeater runat="server" ID="rptAttachments" Visible="False">
            <HeaderTemplate>Attachments: <br/></HeaderTemplate>
            <ItemTemplate>
                <asp:HyperLink runat="server" ID="hlAttachment"/>
                <br/>
            </ItemTemplate>
        </asp:Repeater>

	</div>
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
	
</asp:Content>