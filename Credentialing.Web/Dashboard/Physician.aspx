<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Physician.aspx.cs" Inherits="Credentialing.Web.Dashboard.Physician" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>Physician dashboard</h1>
    
    
    <asp:Repeater runat="server" ID="rptSteps">
        <HeaderTemplate>
            <table>
                <thead>
                    <th>Step</th>
                    <th>Percentage</th>
                </thead>
        </HeaderTemplate>
        
        <ItemTemplate>
            <tr>
                <td><asp:HyperLink ID="hlStep" runat="server"/></td>
                <td><asp:Literal ID="ltrPercentage" runat="server"/></td>
            </tr>
        </ItemTemplate>

        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    
    <asp:Button runat="server" ID="btnStartForm" Text="Begin process"/>
</asp:Content>