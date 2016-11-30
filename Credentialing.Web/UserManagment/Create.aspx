<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Credentialing.Web.UserManagment.Create" MasterPageFile="../Main.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <asp:Label ClientIDMode="Static" AssociatedControlID="tboxUsername" runat="server" Text="Username:" EnableViewState="false" />
    <asp:TextBox runat="server" ID="tboxUsername" />

    <asp:Label runat="server" AssociatedControlID="tboxPassword" Text="Password:" EnableViewState="false" />
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPassword" />

    <asp:Label runat="server" AssociatedControlID="tboxRepeatPassword" Text="Repeat password:" />
    <asp:TextBox runat="server" ID="tboxRepeatPassword" />

    <asp:Label runat="server" AssociatedControlID="tboxEmail" Text="E-mail" EnableViewState="False" />
    <asp:TextBox runat="server" ID="tboxEmail" placeholder="..." />

    <asp:DropDownList runat="server" ID="ddlRole">
        <asp:ListItem Text="Administrator" Value="Admin" />
        <asp:ListItem Text="Physician" Value="Physician" />
    </asp:DropDownList>

    <asp:Button runat="server" ID="btnCreate" Text="Create" />

    <br />
    <br />
    <br />
    <asp:Literal runat="server" ID="ltrErrorMessage" />
</asp:Content>