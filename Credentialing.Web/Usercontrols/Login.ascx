<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="Credentialing.Web.Usercontrols.Login" %>

<asp:Label runat="server" AssociatedControlID="tboxUsername" Text="Username" EnableViewState="False" />
<asp:TextBox runat="server" ID="tboxUsername" />

<asp:Label runat="server" AssociatedControlID="tboxPassword" EnableViewState="False" />
<asp:TextBox runat="server" ID="tboxPassword"  TextMode="Password"/>

<asp:Button runat="server" ID="btnLogin" Text="Login"  />