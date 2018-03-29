<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_DB_Entity.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:GridView ID="guitarsGridView" runat="server">
        </asp:GridView>
        <br />
        Brand: <asp:TextBox ID="brandTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Model: <asp:TextBox ID="modelTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Year: <asp:TextBox ID="yearTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Finish: <asp:TextBox ID="finishTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" Text="Save Data" ID="saveButton" onclick="saveButton_Click"/>
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
