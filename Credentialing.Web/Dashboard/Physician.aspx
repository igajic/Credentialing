<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Physician.aspx.cs" Inherits="Credentialing.Web.Dashboard.Physician" MasterPageFile="../Main.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
	<div class="form-block">
		<h1>Physician dashboard</h1>
		<asp:Repeater runat="server" ID="rptSteps">
			<HeaderTemplate>
			<div class="dashboard-progress">
				<div class="row hidden-sm-down">
					<div class="col-md-4">
						<h5>Step</h5>
					</div>
					<div class="col-md-3">
						<h5 class="centered">Percentage</h5>
					</div>
				</div>
			</HeaderTemplate>
		
			<ItemTemplate>
				<div class="row">
					<div class="col-md-4">
						<div class="form-step-link"><asp:HyperLink ID="hlStep" runat="server"/></div>
					</div>
					<div class="col-md-3 hidden-sm-down">
						<span class="form-step-percentage"><asp:Literal ID="ltrPercentage" runat="server"/></span>
					</div>
					<div class="col-md-5">
						<div class="form-step-progress">
							<span class="text-percent"><asp:Literal ID="ltrProgressBar" runat="server"/></span>
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

	<div class="form-actions">
		<asp:LinkButton runat="server" ID="btnStartForm" Text="Begin process" CssClass="btn btn-next" />
	</div>

</asp:Content>