<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.ascx.cs" Inherits="Credentialing.Web.Usercontrols.CreateUser" %>

<div class="form-row">
	<asp:Label ClientIDMode="Static" AssociatedControlID="tboxUsername" runat="server" Text="Username" EnableViewState="false" />
	<asp:TextBox runat="server" ID="tboxUsername" />
</div>
<div class="form-row">
	<asp:Label runat="server" AssociatedControlID="tboxPassword" Text="Password" EnableViewState="false" />
	<asp:TextBox ClientIDMode="Static" runat="server" ID="tboxPassword" TextMode="Password" />
</div>
<div class="form-row">
	<asp:Label runat="server" AssociatedControlID="tboxRepeatPassword" Text="Repeat password" />
	<asp:TextBox runat="server" ID="tboxRepeatPassword" TextMode="Password" />
</div>
<div class="form-row">
	<asp:Label runat="server" AssociatedControlID="tboxEmail" Text="E-mail" EnableViewState="False" />
	<asp:TextBox runat="server" ID="tboxEmail" />
</div>
<div class="form-row">
	<asp:Label runat="server" AssociatedControlID="ddlRole" Text="User Role" EnableViewState="False" />
	<asp:DropDownList runat="server" ID="ddlRole">
		<asp:ListItem Text="Administrator" Value="Admin" />
		<asp:ListItem Text="Physician" Value="Physician" />
	</asp:DropDownList>
</div>
<div class="form-row align-right">
	<asp:Button runat="server" ID="btnCreate" Text="Create" />
    
    <asp:Button runat="server" ID="btnCancel" Text="Cancel"/>
</div>
<asp:Literal runat="server" ID="ltrErrorMessage"/>