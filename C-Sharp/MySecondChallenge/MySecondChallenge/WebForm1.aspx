<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MySecondChallenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        First Value:
        <asp:TextBox ID="firstValueTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Second Value:
        <asp:TextBox ID="secondValueTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="add" runat="server" OnClick="add_Click" Text="+" />
&nbsp;<asp:Button ID="subtract" runat="server" OnClick="subtract_Click" Text="-" />
&nbsp;<asp:Button ID="multiply" runat="server" OnClick="multiply_Click" Text="*" />
&nbsp;<asp:Button ID="divide" runat="server" OnClick="divide_Click" Text="/" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: 700; background-color: #3366FF"></asp:Label>
    
    </div>
    </form>
</body>
</html>
