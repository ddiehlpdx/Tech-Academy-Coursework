<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyThirdChallenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Choose a House:<br />
        <br />
        <asp:RadioButton ID="stark" runat="server" GroupName="houses" Text="Stark" />
        <br />
        <asp:RadioButton ID="baratheon" runat="server" GroupName="houses" Text="Baratheon" />
        <br />
        <asp:RadioButton ID="greyjoy" runat="server" GroupName="houses" Text="Greyjoy" />
        <br />
        <asp:RadioButton ID="martell" runat="server" GroupName="houses" Text="Martell" />
        <br />
        <br />
        <asp:Image ID="houseImage" runat="server" Height="150px" Width="150px" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
