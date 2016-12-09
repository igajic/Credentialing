<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.ascx.cs" Inherits="Credentialing.Web.Usercontrols.CreateUser" %>
    <asp:Label ID="Label1" ClientIDMode="Static" AssociatedControlID="tboxUsername" runat="server" Text="Username:" EnableViewState="false" />
    <asp:TextBox runat="server" ID="tboxUsername" />

    <asp:Label ID="Label2" runat="server" AssociatedControlID="tboxPassword" Text="Password:" EnableViewState="false" />
    <asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPassword" TextMode="Password" />

    <asp:Label ID="Label3" runat="server" AssociatedControlID="tboxRepeatPassword" Text="Repeat password:" />
    <asp:TextBox runat="server" ID="tboxRepeatPassword" TextMode="Password" />

    <asp:Label ID="Label4" runat="server" AssociatedControlID="tboxEmail" Text="E-mail" EnableViewState="False" />
    <asp:TextBox runat="server" ID="tboxEmail" />

    <asp:DropDownList runat="server" ID="ddlRole">
        <asp:ListItem Text="Administrator" Value="Admin" />
        <asp:ListItem Text="Physician" Value="Physician" />
    </asp:DropDownList>

    <asp:Button runat="server" ID="btnCreate" Text="Create" />

    <br />
    <br />
    <br />
    <asp:Literal runat="server" ID="ltrErrorMessage" />