<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_Final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="./Content/bootstrap.min.css" rel="stylesheet" />
    <link href="./Content/style.css" rel="stylesheet" />
    <script src="./Content/bootstrap.min.js"></script>
    <title>Order some pizza!</title>
</head>
<body class="bg-secondary">
    
    <form id="form1" runat="server">
        <h2 class="text-center">We're Ordering Pizza Again!</h2>
        <div class="container bg-dark p-3">
            <div class="form-group">
                <label for="size">Size:</label>
                <asp:DropDownList class="form-control" ID="size" runat="server" AutoPostBack="True" OnSelectedIndexChanged="size_SelectedIndexChanged">
                    <asp:ListItem Value="choose">Choose a size...</asp:ListItem>
                    <asp:ListItem Value="small">Small ($12)</asp:ListItem>
                    <asp:ListItem Value="medium">Medium ($14)</asp:ListItem>
                    <asp:ListItem Value="large">Large ($16)</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="crust">Crust:</label>
                <asp:DropDownList class="form-control" ID="crust" runat="server" AutoPostBack="True" OnSelectedIndexChanged="crust_SelectedIndexChanged">
                    <asp:ListItem Value="choose">Choose a crust...</asp:ListItem>
                    <asp:ListItem Value="regular">Regular</asp:ListItem>
                    <asp:ListItem Value="thin">Thin</asp:ListItem>
                    <asp:ListItem Value="thick">Thick (+ $2)</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-check">
                <asp:CheckBox ID="pepperoni" runat="server" AutoPostBack="True" />
                <label class="form-check-label" for="pepperoni">
                        Pepperoni
                </label>
            </div>
            <div class="form-check">
                <asp:CheckBox ID="sausage" runat="server" AutoPostBack="True" />
                <label class="form-check-label" for="sausage">
                    Sausage
                </label>
            </div>
            <div class="form-check">
                <asp:CheckBox ID="mushrooms" runat="server" AutoPostBack="True" />
                <label class="form-check-label" for="mushrooms">
                    Mushrooms
                </label>
            </div>
            <div class="form-check">
                <asp:CheckBox ID="peppers" runat="server" AutoPostBack="True" />
                <label class="form-check-label" for="peppers">
                    Peppers
                </label>
            </div>
            <h5 class="mt-3">Deliver To:</h5>
            <div class="form-group">
                <label for="name">Name:</label>
                <asp:TextBox class="form-control" ID="name" runat="server" AutoPostBack="True"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="name">Address:</label>
                <asp:TextBox class="form-control" ID="address" runat="server" AutoPostBack="True"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="name">Zip:</label>
                <asp:TextBox class="form-control" ID="zip" runat="server" AutoPostBack="True"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="name">Phone:</label>
                <asp:TextBox class="form-control" ID="phone" runat="server" AutoPostBack="True"></asp:TextBox>
            </div>
            <h5 class="mt-3">Payment Method:</h5>
            <div class="form-check">
                <asp:RadioButton ID="cashRadio" runat="server" GroupName="payment" AutoPostBack="True" />
                <label class="form-check-label" for="cashRadio">
                  Cash
                </label>
            </div>
            <div class="form-check">
                <asp:RadioButton ID="cardRadio" runat="server" GroupName="payment" AutoPostBack="True" />
                <label class="form-check-label" for="cardRadio">
                  Card
                </label>
            </div>
            <asp:Button class="btn btn-light mt-2 mb-1" ID="submitButton" runat="server" Text="Place Order!" OnClick="submitButton_Click" />
            &nbsp;&nbsp;<asp:Label ID="totalLabel" runat="server"></asp:Label>
            <br />


            
        </div>
    </form>
    
</body>
</html>
