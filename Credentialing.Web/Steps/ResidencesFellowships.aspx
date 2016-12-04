<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResidencesFellowships.aspx.cs" Inherits="Credentialing.Web.Steps.ResidencesFellowships" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<div class="form-block">
		<div class="form-heading">
			<h2><strong>7.</strong> Residencies / Fellowships</h2>
		</div>
		<h1>Coming soon</h1>
		<asp:Panel ID="Panel1" runat="server" Enabled="false" Visible="false">
		<div class="row">
			<div class="col-md-12">
				<p>Include residencies, fellowships, Preceptorship, teaching appointments (indicate whether clinical or academic), and postgraduate education in chronological order, giving name, address, city, ZIP code, and dates. Include <strong>all</strong> programs you attended, whether or not completed.</p>
			</div>
		</div>
		</asp:Panel>
	</div>
	<asp:Panel ID="Panel2" runat="server" Enabled="false" Visible="false">
	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnPrevious" Text="Previous" CssClass="btn btn-prev" />
		<asp:LinkButton runat="server" ID="btnNext" Text="Next" CssClass="btn btn-next" />
	</div>
	</asp:Panel>
</asp:Content>