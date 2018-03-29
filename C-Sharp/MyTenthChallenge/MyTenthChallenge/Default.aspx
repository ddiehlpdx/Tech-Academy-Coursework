<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyTenthChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="initialStringToReverse" runat="server"></asp:Label>
    
    </div>
        <br />
        <asp:Button ID="reverseStringButton" runat="server" OnClick="reverseStringButton_Click" Text="Reverse String" />
        <br />
        <br />
        <asp:Label ID="reverseStringResult" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="secondStringToReverse" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="secondReverseButton" runat="server" OnClick="secondReverseButton_Click" Text="Reverse String" />
        <br />
        <br />
        <asp:Label ID="secondReverseLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="initialStringToPad" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="padButton" runat="server" OnClick="padButton_Click" Text="Pad That Shit" />
        <br />
        <br />
        <asp:Label ID="padResultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="puzzleLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="puzzleButton" runat="server" OnClick="puzzleButton_Click" Text="Solve It" />
        <br />
        <br />
        <asp:Label ID="puzzleResultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
