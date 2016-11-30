<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InternshipPGYI.aspx.cs" Inherits="Credentialing.Web.Steps.InternshipPGYI" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>VI. INTERNSHIP/PGYI</h1>
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>

    <asp:Panel ID="Panel1" runat="server" Enabled="false" Visible="false">
        <asp:Label runat="server" AssociatedControlID="tboxInstitution" Text="Institution" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxInstitution"/>

        <asp:Label runat="server" AssociatedControlID="tboxProgramDirector" Text="Program Director:" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxProgramDirector"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingAddress" Text="Mailing Address:" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAddress"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingCity" Text="City:" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingCity"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingStateCountry" Text="State & Country:" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingStateCountry"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingZip" Text="ZIP:" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingZip"></asp:TextBox>

        <asp:Label runat="server" AssociatedControlID="tboxTypeInternship" Text="Type of Internship:" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxTypeInternship"/>

        <asp:Label runat="server" AssociatedControlID="tboxSpecialty" Text="Specialty:" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSpecialty"/>

        <asp:Label runat="server" AssociatedControlID="tboxFromDate" Text="From: (mm/yy)" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxFromDate"/>

        <asp:Label runat="server" AssociatedControlID="tboxToDate" Text="To: (mm/yy)" EnableViewState="false"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxToDate"/>
    

        <asp:FileUpload ClientIDMode="Static" runat="server" ID="fuInternship" AllowMultiple="True"/>
    </asp:Panel>
</asp:Content>