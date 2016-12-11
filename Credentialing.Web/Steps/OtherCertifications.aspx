<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtherCertifications.aspx.cs" Inherits="Credentialing.Web.Steps.OtherCertifications" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h4>IX. OTHER CERTIFICATIONS (E.G. FLUOROSCOPY, RADIOGRAPHY, ETC.)<br/>Attach additional sheets if necessary</h4>
    
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>
    
    <asp:Panel runat="server" Visible="False">
        <asp:Label runat="server" AssociatedControlID="tboxPrimaryType" Text="Type:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimaryType" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryNumber" Text="Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimaryNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryExpirationDate" Text="Expiration Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimaryExpirationDate" ClientIDMode="Static"/>


        <asp:Label runat="server" AssociatedControlID="tboxSecondryType" Text="Type:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondryType" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryNumber" Text="Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" id="tboxSecondaryNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryExpirationDate" Text="Expiration Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondaryExpirationDate" ClientIDMode="Static"/>
    
        <asp:FileUpload runat="server" ID="fuAttachment" ClientIDMode="Static"/>
        
        
	    <div class="form-actions">
		    <asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		    <asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	    </div>
        

    </asp:Panel>
</asp:Content>