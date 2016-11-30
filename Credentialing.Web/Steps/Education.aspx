<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Education.aspx.cs" Inherits="Credentialing.Web.Steps.Education"  MasterPageFile="../Main.Master"%>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>IV. EDUCATION</h1>
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>

    <asp:Panel ID="Panel1" runat="server" Enabled="false" Visible="false">
        <asp:Label runat="server" AssociatedControlID="tboxCollegeUniversityName" Text="College or University Name:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxCollegeUniversityName"/>

        <asp:Label runat="server" AssociatedControlID="tboxDegreeReceived" Text="Degree Received:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDegreeReceived"/>

        <asp:Label runat="server" AssociatedControlID="tboxDateOfGraduation" Text="Date of Graduation (mm/yy)" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDateOfGraduation"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingAddress" Text="Mailing Address:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAddress"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingCity" Text="City:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingCity"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingState" Text="State:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingState"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingZip" Text="ZIP:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingZip" />
    
    
        <asp:FileUpload ClientIDMode="Static" runat="server" ID="fuAttachments" AllowMultiple="True"/>
    </asp:Panel>
</asp:Content>