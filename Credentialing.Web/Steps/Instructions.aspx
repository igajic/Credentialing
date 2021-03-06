﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instructions.aspx.cs" Inherits="Credentialing.Web.Steps.Instructions" MasterPageFile="../Main.Master" %>
<%@ Register src="~/Usercontrols/SidebarProgress.ascx" tagPrefix="uc" tagName="SidebarProgress" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">

	<uc:SidebarProgress runat="server" CurrentStep="1" EnableViewState="false"/>
	<div class="form-block">
		<p>
			<strong>This form should be typed or legibly printed in black or blue ink.</strong> If more space is needed than provided on original, attach additional sheets and reference the question being answered. Please do not use abbrevations when completing the application.
		</p>
		<p>
			<strong>Current copies of the following documents must be submitted with this application:</strong>
		</p>
		<ul>
			<li>State Medical/Professional License(s)</li>
			<li>Face Sheet of Professional Liability Policy or Certification</li>
			<li>ECFMG (if applicable)</li>
			<li>DEA Certificate</li>
			<li>Curriculum Vitae</li>
			<li>Board Certification (if applicable)</li>
		</ul>
	</div>
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
</asp:Content>