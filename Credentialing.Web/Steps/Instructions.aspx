<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instructions.aspx.cs" Inherits="Credentialing.Web.Steps.Instructions" MasterPageFile="../Main.Master" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <h1>I. INSTRUCTIONS</h1>

    <p>
        <strong>This form should be typed or legibly printed in black or blue ink.</strong> If more space is needed than provided on original, attach additional sheets and reference the question being answered. Please do not use abbrevations when completing the application.
        <strong>Current copies of the following documents must be submitted with this application:</strong>
        <ul>
            <li>State Medical/Professional License(s)</li>
            <li>Face Sheet of Professional Liability Policy or Certification</li>
            <li>ECFMG (if applicable)</li>
            <li>DEA Certificate</li>
            <li>Curriculum Vitae</li>
            <li>Board Certification (if applicable)</li>
        </ul>
    </p>
    
    
    <asp:Button runat="server" ID="btnNext" Text="Next"/>
</asp:Content>
