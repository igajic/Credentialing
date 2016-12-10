<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="Credentialing.Web.Dashboard.Administrator" MasterPageFile="../Main.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>Administrator dashboard</h1>

    <asp:Repeater runat="server" ID="rptUsers">
        <HeaderTemplate>
            <table border="1">
                <thead>
                    <th>User</th>
                    <th>Percentage</th>
                </thead>
        </HeaderTemplate>

        <ItemTemplate>
            <tr>
                <td>
                    <asp:Literal ID="ltrUser" runat="server" /></td>
                <td>
                    <asp:Literal ID="ltrPercentage" runat="server" /></td>
            </tr>
        </ItemTemplate>

        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>