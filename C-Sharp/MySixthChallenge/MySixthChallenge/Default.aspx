<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MySixthChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="./images/epic-spies-logo.jpg" Width="145px" />
        <br />
        <br />
        <h1>Asset Performance Tracker</h1>
        Asset Name: <asp:TextBox ID="assetTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged: <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts of subterfuge:
        <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
