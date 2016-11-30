<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicalProfessionalEducation.aspx.cs" Inherits="Credentialing.Web.Steps.MedicalProfessionalEducation"  MasterPageFile="../Main.Master"%>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>V. MEDICAL/PROFESSIONAL EDUCATION</h1>
    
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>

    <asp:Panel ID="Panel1" runat="server" Enabled="false">
        <asp:Label runat="server" AssociatedControlID="tboxMedicalProfessionalSchoolFirst" Text="Medical/Professional School:" EnableViewState="False" />
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMedicalProfessionalSchoolFirst"/>

        <asp:Label runat="server" AssociatedControlID="tboxDegreeReceivedFirst" Text="Degree Received:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDegreeReceivedFirst"/>

        <asp:Label runat="server" AssociatedControlID="tboxDateGraduationFirst" Text="Date of Graduation (mm/yy)" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDateGraduationFirst"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingAdrressFirst" Text="Mailing Address:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAdrressFirst"/>
    
        <asp:Label runat="server" AssociatedControlID="tboxMailingCityFirst" Text="City:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingCityFirst"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingStateFirst" Text="State:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingStateFirst"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingZipFirst" Text="ZIP:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingZipFirst"/>
    
        <asp:Label runat="server" AssociatedControlID="tboxMedicalProfessionalSchoolSecond" Text="Medical/Professional School:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMedicalProfessionalSchoolSecond"/>

        <asp:Label runat="server" AssociatedControlID="tboxDegreeReceivedSecond" Text="Degree Received:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDegreeReceivedSecond"/>

        <asp:Label runat="server" AssociatedControlID="tboxDateGraduationSecond" Text="Date of Graduation (mm/yy)" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxDateGraduationSecond"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingAdrressSecond" Text="Mailing Address:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingAdrressSecond"/>
    
        <asp:Label runat="server" AssociatedControlID="tboxMailingCitySecond" Text="City:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingCitySecond"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingStateSecond" Text="State:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingStateSecond"/>

        <asp:Label runat="server" AssociatedControlID="tboxMailingZipSecond" Text="ZIP:" EnableViewState="False"/>
        <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMailingZipSecond"/>
    
        <asp:FileUpload ClientIDMode="Static" runat="server" ID="fuAttachments"/>
    </asp:Panel>
</asp:Content>