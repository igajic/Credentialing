<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkHistory.aspx.cs" Inherits="Credentialing.Web.Steps.WorkHistory" MasterPageFile="../Main.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>XV. WORK HISTORY</h1>
    <br />
    <br />
    <br />
    <br />

    <h1>Coming soon</h1>

    <asp:Panel runat="server" Visible="false">
        <p>Chronologically list all work history activities since completion of postgraduate training (use extra sheets if necessary). This information must be complete. A curriculum vitae is sufficient provided it is current and contains all information requested below. Please explain any gaps in professional work history in designated area at end of this section. Work History MUST INCLUDE practice location (address).</p>

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryNamePracticeEmployer" Text="Current Practice:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryNamePracticeEmployer" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryContactName" Text="Contact Name:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryContactName" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryTelephoneNumber" Text="Telephone Number:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryTelephoneNumber" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryFaxNumber" Text="Fax Number:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryFaxNumber" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryPracticeAddress" Text="Practice Address:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryPracticeAddress" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryCity" Text="City:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryCity" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryState" Text="State" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryState" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryStartDate" Text="Start Date:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryStartDate" ClientIDMode="Static" placeholder="mm/yy" />

        <asp:Label runat="server" AssociatedControlID="tboxPrimaryEndDate" Text="End Date:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxPrimaryEndDate" ClientIDMode="Static" placeholder="mm/yy" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryNamePracticeEmployer" Text="Name of Practice/Employer:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryNamePracticeEmployer" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryContactName" Text="Contact Name:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryContactName" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryTelephoneNumber" Text="Telephone Number:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryTelephoneNumber" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryFaxNumber" Text="Fax Number:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryFaxNumber" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryPracticeAddress" Text="Practice Address:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryPracticeAddress" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryCity" Text="City:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryCity" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryState" Text="State" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryState" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryStartDate" Text="Start Date:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryStartDate" ClientIDMode="Static" placeholder="mm/yy" />

        <asp:Label runat="server" AssociatedControlID="tboxSecondaryEndDate" Text="End Date:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxSecondaryEndDate" ClientIDMode="Static" placeholder="mm/yy" />

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryNamePracticeEmployer" Text="Name of Practice/Employer:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxTertiaryNamePracticeEmployer" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryContactName" Text="Contact Name:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxTertiaryContactName" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryTelephoneNumber" Text="Telephone Number:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxTertiaryTelephoneNumber" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryFaxNumber" Text="Fax Number:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxTertiaryFaxNumber" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryPracticeAddress" Text="Practice Address:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxTertiaryPracticeAddress" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryCity" Text="City:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxTertiaryCity" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryState" Text="State" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxTertiaryState" ClientIDMode="Static" />

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryStartDate" Text="Start Date:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxTertiaryStartDate" ClientIDMode="Static" placeholder="mm/yy" />

        <asp:Label runat="server" AssociatedControlID="tboxTertiaryEndDate" Text="End Date:" EnableViewState="False" />
        <asp:TextBox runat="server" ID="tboxTertiaryEndDate" ClientIDMode="Static" placeholder="mm/yy" />

        <h4>EXPLANATION FOR BREAKS IN WORK HISTORY</h4>
        <h5>Explanations must be given for breaks of six months or more)</h5>

        <asp:TextBox runat="server" ID="tboxExplanation" TextMode="MultiLine" ClientIDMode="Static" />

        <asp:FileUpload runat="server" ID="fuAttachments" AllowMultiple="True" ClientIDMode="Static" />

        <div class="form-actions">
            <asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
            <asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
        </div>
    </asp:Panel>
</asp:Content>