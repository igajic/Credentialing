<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Credentialing.Web.UserManagment.Create" MasterPageFile="../Main.Master" %>
<%@ Register Src="~/Usercontrols/CreateUser.ascx" TagPrefix="uc" TagName="CreateUser" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <uc:CreateUser runat="server" />
</asp:Content>