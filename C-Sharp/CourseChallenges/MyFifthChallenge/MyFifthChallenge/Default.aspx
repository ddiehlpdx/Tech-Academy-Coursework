<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFifthChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="image" runat="server" Height="190px" Width="165px" />
        <br />
        <br />
        Code Name: <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Assignment: <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Previous Assignment End Date:<asp:Calendar ID="calendar1" runat="server"></asp:Calendar>
        <br />
        New Assignment Start Date:<asp:Calendar ID="calendar2" runat="server"></asp:Calendar>
        <br />
        New Assignment Projected End Date:<asp:Calendar ID="calendar3" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Mission" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
