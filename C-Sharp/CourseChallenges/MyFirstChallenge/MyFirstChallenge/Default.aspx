<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstChallenge.Challenge_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How old are you?&nbsp;
        <asp:TextBox ID="age" runat="server"></asp:TextBox>
        <br />
        <br />
        How much money is in your pockets?&nbsp;
        <asp:TextBox ID="cash" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Get Your Fortune" />
        <br />
        <br />
        <asp:Label ID="submitLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
