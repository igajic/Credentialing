<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IdentifyingInformation.aspx.cs" Inherits="Credentialing.Web.Steps.IdentifyingInformation" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>II. IDENTIFYING INFORMATION</h1>

    <asp:Label runat="server" AssociatedControlID="tboxLastName" Text="Last Name:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxLastName"/>

    <asp:Label runat="server" AssociatedControlID="tboxFirstName" Text="First:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxFirstName"/>

    <asp:Label runat="server" AssociatedControlID="tboxMiddleName" Text="Middle:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMiddleName"/>

    <asp:Label runat="server" AssociatedControlID="tboxOtherKnownNames" Text="Is there any other name under which you have been known? Name (s):" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxOtherKnownNames"/>

    <asp:Label runat="server" AssociatedControlID="tboxHomeMailingAddress" Text="Home Mailing Address:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxHomeMailingAddress"/>

    <asp:Label runat="server" AssociatedControlID="tboxCity" Text="City:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxCity"/>

    <asp:Label runat="server" AssociatedControlID="tboxState" Text="State:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxState"/>

    <asp:Label runat="server" AssociatedControlID="tboxZip" Text="ZIP:" EnableViewState="False"/>
    <asp:TextBox  ClientIDMode="Static" runat="server" ID="tboxZip"/>

    <asp:Label runat="server" AssociatedControlID="tboxHomeTelephoneNumber" Text="Home Telephone Number:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxHomeTelephoneNumber"/>

    <asp:Label runat="server" AssociatedControlID="tboxHomeFaxNumber" Text="Home Fax Number:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxHomeFaxNumber"/>

    <asp:Label runat="server" AssociatedControlID="tboxEmailAddress" Text="E-Mail Address:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxEmailAddress"/>

    <asp:Label runat="server" AssociatedControlID="tboxPagerNumber" Text="Pager Number:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPagerNumber"/>

    <asp:Label runat="server" AssociatedControlID="tboxBirthDate" Text="Birth Date:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxBirthDate"/>

    <asp:Label runat="server" AssociatedControlID="tboxBirthPlace" Text="Birth Place (City/State/Country):" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxBirthPlace"/>

    <asp:Label runat="server" Text="Citizenship (If not a United States citizen, please include copy of Alien Registration Card)"/>
    <asp:FileUpload ClientIDMode="Static" runat="server" ID="fuAlienRegistrationCard"/>

    <asp:Label runat="server" AssociatedControlID="tboxSocialSecurityNumber" Text="Social Security #:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSocialSecurityNumber" EnableViewState="False"/>
    
    <asp:Label runat="server" AssociatedControlID="rbtnMale" EnableViewState="False">Gender<sup>2</sup>:</asp:Label>
    <asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnMale" GroupName="Gender"/>
    <asp:RadioButton ClientIDMode="Static" runat="server" ID="rbtnFemale" GroupName="Gender"/>

    <asp:Label runat="server" AssociatedControlID="tboxSpecialty" Text="Specialty:" EnableViewState="False"/>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxSpecialty"/>
    
    <asp:Label runat="server" AssociatedControlID="tboxRaceEthnicity" EnableViewState="False">Race/Ethnicity<sup>2</sup>(voluntary)</asp:Label>
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxRaceEthnicity" />

    <asp:Label runat="server" AssociatedControlID="tboxSubspeciality" EnableViewState="False"/>
    <asp:TextBox runat="server" ClientIDMode="Static" ID="tboxSubspeciality"/>
    

    <asp:Button runat="server" ID="btnPrevious" Text="Previous"/>
    <br/>
    <asp:Button runat="server" ID="btnNext" Text="Next"/>
</asp:Content>