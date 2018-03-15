<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyEighthChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Postal Calculator<br />
        <br />
        Width:
        <asp:TextBox ID="widthTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Height: <asp:TextBox ID="heightTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Length:
        <asp:TextBox ID="lengthTextBox" runat="server"></asp:TextBox>
&nbsp;(Optional)<br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="shippingMethod" OnCheckedChanged="groundRadioButton_CheckedChanged" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="shippingMethod" OnCheckedChanged="airRadioButton_CheckedChanged" Text="Air" />
        <br />
        <asp:RadioButton ID="nextDayRadioButton" runat="server" AutoPostBack="True" GroupName="shippingMethod" OnCheckedChanged="nextDayRadioButton_CheckedChanged" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="boom" runat="server" BorderStyle="None" Height="180px" Width="300px" />
    </form>
</body>
</html>
