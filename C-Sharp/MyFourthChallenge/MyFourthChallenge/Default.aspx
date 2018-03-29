<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFourthChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            How many days have elapsed?</p>
        <p>
            &nbsp;</p>
        <p>
            Choose a date:</p>
        <p>
            <asp:Calendar ID="calendar1" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            And a second date:</p>
        <p>
            <asp:Calendar ID="calendar2" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Go!" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
