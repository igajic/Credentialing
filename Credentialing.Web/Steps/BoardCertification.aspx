<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BoardCertification.aspx.cs" Inherits="Credentialing.Web.Steps.BoardCertification" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<h1>VIII. BOARD CERTIFICATION</h1>
	<br />
	<br />
	<br />
	<br />

	<h1>Coming soon</h1>

	<asp:Panel ID="Panel1" runat="server" Enabled="false" Visible="false">
		<p>
			Include certifications by board(s) which are duly organized and recognized by:
		</p>
		<ul>
			<li>a member board of the American Board of Medical Specialties</li>
			<li>a member board of the American Osteopathic Association</li>
			<li>a board or association with an Accreditation Council for Graduate Medical Education or American Osteopathic Association approved postgraduate training that provides complete training in that specialty or subspecialty</li>
		</ul>

	    <asp:Label runat="server" AssociatedControlID="tboxPrimaryNameIssuingBoard" Text="Name of Issuing Board:" EnableViewState="False"/>
	    <asp:TextBox runat="server" ID="tboxPrimaryNameIssuingBoard" ClientIDMode="Static"/>

	    <asp:Label runat="server" AssociatedControlID="tboxPrimarySpecialty" Text="Specialty:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimarySpecialty" ClientIDMode="Static"/>

	    <asp:Label runat="server" AssociatedControlID="tboxPrimaryDateCertifiedRecertified" Text="Date Certified/Recertified:" EnableViewState="False"/>
	    <asp:TextBox runat="server" ID="tboxPrimaryDateCertifiedRecertified" ClientIDMode="Static"/>

	    <asp:Label runat="server" AssociatedControlID="tboxPrimaryExpirationDate" Text="Expiration Date (if any):" EnableViewState="False"/>
	    <asp:TextBox runat="server" ID="tboxPrimaryExpirationDate" ClientIDMode="Static"/>
        
        

	    <asp:Label runat="server" AssociatedControlID="tboxSecondaryNameIssuingBoard" Text="Name of Issuing Board:" EnableViewState="False"/>
	    <asp:TextBox runat="server" ID="tboxSecondaryNameIssuingBoard" ClientIDMode="Static"/>

	    <asp:Label runat="server" AssociatedControlID="tboxSecondarySpecialty" Text="Specialty:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondarySpecialty" ClientIDMode="Static"/>

	    <asp:Label runat="server" AssociatedControlID="tboxSecondaryDateCertifiedRecertified" Text="Date Certified/Recertified:" EnableViewState="False"/>
	    <asp:TextBox runat="server" ID="tboxSecondaryDateCertifiedRecertified" ClientIDMode="Static"/>

	    <asp:Label runat="server" AssociatedControlID="tboxSecondaryExpirationDate" Text="Expiration Date (if any):" EnableViewState="False"/>
	    <asp:TextBox runat="server" ID="tboxSecondaryExpirationDate" ClientIDMode="Static"/>
        
        
	    <asp:Label runat="server" AssociatedControlID="tboxTertiaryNameIssuingBoard" Text="Name of Issuing Board:" EnableViewState="False"/>
	    <asp:TextBox runat="server" ID="tboxTertiaryNameIssuingBoard" ClientIDMode="Static"/>

	    <asp:Label runat="server" AssociatedControlID="tboxTertiarySpecialty" Text="Specialty:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxTertiarySpecialty" ClientIDMode="Static"/>

	    <asp:Label runat="server" AssociatedControlID="tboxTertiaryDateCertifiedRecertified" Text="Date Certified/Recertified:" EnableViewState="False"/>
	    <asp:TextBox runat="server" ID="tboxTertiaryDateCertifiedRecertified" ClientIDMode="Static"/>

	    <asp:Label runat="server" AssociatedControlID="tboxTertiaryExpirationDate" Text="Expiration Date (if any):" EnableViewState="False"/>
	    <asp:TextBox runat="server" ID="tboxTertiaryExpirationDate" ClientIDMode="Static"/>
        
        
        <span>Have you applied for board certification other than those indicated above?</span>

        <asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnYes" GroupName="BoardCert" />
	    <asp:Label runat="server" AssociatedControlID="rbtnYes" EnableViewState="False" Text="Yes"/>
        
        <asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnNo" GroupName="BoardCert" />
	    <asp:Label runat="server" AssociatedControlID="rbtnNo" EnableViewState="False" Text="No"/>

	    <asp:Label runat="server" AssociatedControlID="tboxAdditionalListBoardsDates" Text="If so, list board(s) and date(s):" EnableViewState="False" />
	    <asp:TextBox runat="server" ID="tboxAdditionalListBoardsDates" ClientIDMode="Static"/>

        <asp:FileUpload runat="server" ID="fuAttachments" AllowMultiple="True"/>
	</asp:Panel>
</asp:Content>