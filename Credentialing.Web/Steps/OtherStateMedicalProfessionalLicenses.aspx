<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OtherStateMedicalProfessionalLicenses.aspx.cs" Inherits="Credentialing.Web.Steps.OtherStateMedicalProfessionalLicenses" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>XI. ALL OTHER STATE MEDICAL/PROFESSIONAL LICENSES. List All Medical/Professional Licenses Now or Previously Held.</h1>
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>
    <asp:Panel runat="server" Visible="False">
        <asp:Label runat="server" AssociatedControlID="tboxPrimaryState" Text="State:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimaryState" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryLicenseNumber" Text="License Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimaryLicenseNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryExpirationDate" Text="Exp. Date" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimaryExpirationDate" ClientIDMode="Static"/>
        
        <asp:Label runat="server" AssociatedControlID="tboxPrimaryLastExpirationDate" Text="If inactive, last Exp. Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxPrimaryLastExpirationDate" ClientIDMode="Static"/>
        
        
        <asp:Label runat="server" AssociatedControlID="tboxSecondaryState" Text="State:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondaryState" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryLicenseNumber" Text="License Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondaryLicenseNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryExpirationDate" Text="Exp. Date" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondaryExpirationDate" ClientIDMode="Static"/>
        
        <asp:Label runat="server" AssociatedControlID="tboxSecondaryLastExpirationDate" Text="If inactive, last Exp. Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxSecondaryLastExpirationDate" ClientIDMode="Static"/>
        
        
        <asp:Label runat="server" AssociatedControlID="tboxTertiaryState" Text="State:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxTertiaryState" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryLicenseNumber" Text="License Number:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxTertiaryLicenseNumber" ClientIDMode="Static"/>

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryExpirationDate" Text="Exp. Date" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxTertiaryExpirationDate" ClientIDMode="Static"/>
        
        <asp:Label runat="server" AssociatedControlID="tboxTertiaryLastExpirationDate" Text="If inactive, last Exp. Date:" EnableViewState="False"/>
        <asp:TextBox runat="server" ID="tboxTertiaryLastExpirationDate" ClientIDMode="Static"/>
    </asp:Panel>
</asp:Content>