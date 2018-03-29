<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyNinthChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="reel1" runat="server" Height="150px" Width="150px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="reel2" runat="server" Height="150px" Width="150px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="reel3" runat="server" Height="150px" Width="150px" />
        <br />
        <br />
        Your Bet:
        <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull The Lever!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="runningTotalLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry: Double your bet!<br />
        2 Cherries: Triple your bet!<br />
        3 Cherries: Quadruple your bet!!<br />
        3 7s - JACKPOT!: 100x your bet!<br />
        HOWEVER... If you get even one Bar you lose your bet!<br />
        <br />
        Good luck!<br />
        <br />
        <asp:Image ID="borat" runat="server" Height="256px" Width="256px" />
    
    </div>
    </form>
</body>
</html>
