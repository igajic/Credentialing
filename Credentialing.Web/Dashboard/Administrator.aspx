<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="Credentialing.Web.Dashboard.Administrator" MasterPageFile="../Main.Master" %>

<asp:Content ContentPlaceHolderID="footer" runat="server">
	<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
	<script type="text/javascript" src="/Scripts/admin-dashboard.js"></script>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">

	<div class="form-block">
		<h1>Administrator dashboard</h1>
		<asp:Repeater runat="server" ID="rptUsers">
			<HeaderTemplate>
			<div class="dashboard-progress admin-dashboard js-open-user-dashboard">
				<div class="row hidden-sm-down">
					<div class="col-md-6">
						<h5>User</h5>
					</div>
					<div class="col-lg-4 col-md-6">
						<h5 class="centered">Progress</h5>
					</div>
				</div>
			</HeaderTemplate>

			<ItemTemplate>
				<div class="row">
					<div class="col-md-6">
						<div class="form-step-link"><asp:Literal ID="ltrUser" runat="server" /></div>
					</div>
					<div class="col-lg-4 col-md-6">
						<div class="form-step-progress">
							<span class="text-percent"><asp:Literal ID="ltrPercentage" runat="server"/></span>
							<span class="progress-bar"></span>
						</div>
					</div>
				</div>
			</ItemTemplate>

			<FooterTemplate>
			</div>
			</FooterTemplate>
		</asp:Repeater>
	</div>

	<div id="piechart" class="piechart"></div>

</asp:Content>