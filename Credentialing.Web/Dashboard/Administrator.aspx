<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="Credentialing.Web.Dashboard.Administrator" MasterPageFile="../Main.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<div class="form-block">
		<h1>Administrator dashboard</h1>
		<asp:Repeater runat="server" ID="rptUsers">
			<HeaderTemplate>
			<div class="dashboard-progress">
				<div class="row">
					<div class="col-md-6">
						<div class="row hidden-sm-down">
							<div class="col-md-6">
								<h5>User</h5>
							</div>
							<div class="col-md-6">
								<h5 class="centered">Percentage</h5>
							</div>
						</div>
			</HeaderTemplate>

			<ItemTemplate>
				<div class="row">
					<div class="col-md-6 col-xs-8">
						<div class="form-step-link"><asp:Literal ID="ltrUser" runat="server" /></div>
					</div>
					<div class="col-md-6 col-xs-4">
						<span class="form-step-percentage"><asp:Literal ID="ltrPercentage" runat="server" /></span>
					</div>
				</div>
			</ItemTemplate>

			<FooterTemplate>
					</div>
				</div>
			</div>
			</FooterTemplate>
		</asp:Repeater>
	</div>
</asp:Content>