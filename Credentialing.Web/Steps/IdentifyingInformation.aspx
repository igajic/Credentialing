<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IdentifyingInformation.aspx.cs" Inherits="Credentialing.Web.Steps.IdentifyingInformation" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="form-block">
        <div class="form-heading">
            <h2><strong>2.</strong> Identifying information</h2>
        </div>
        <div class="row">
            <div class="col-md-5">
                <asp:Label ID="Label1" runat="server" AssociatedControlID="tboxLastName" Text="Last Name:" EnableViewState="False"/>
                <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxLastName"/>
            </div>
            <div class="col-md-4">
                <asp:Label ID="Label2" runat="server" AssociatedControlID="tboxFirstName" Text="First:" EnableViewState="False"/>
                <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxFirstName"/>
            </div>
            <div class="col-md-3">
                <asp:Label ID="Label3" runat="server" AssociatedControlID="tboxMiddleName" Text="Middle:" EnableViewState="False"/>
                <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxMiddleName"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:Label runat="server" AssociatedControlID="tboxOtherKnownNames" Text="Is there any other name under which you have been known? Name (s):" EnableViewState="False"/>
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
                <asp:Label ID="Label4" runat="server" AssociatedControlID="tboxCity" Text="City:" EnableViewState="False"/>
                <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxCity"/>
            </div>
            <div class="col-md-4">
                <asp:Label ID="Label5" runat="server" AssociatedControlID="tboxState" Text="State:" EnableViewState="False"/>
                <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxState"/>
            </div>
            <div class="col-md-3">
                <asp:Label ID="Label6" runat="server" AssociatedControlID="tboxZip" Text="ZIP:" EnableViewState="False"/>
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
    </div>
    <div class="form-actions">
        <asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
        <asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
    </div>
</asp:Content>