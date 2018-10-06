<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockInUI.aspx.cs" Inherits="DEmo.UI.StockInUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
        }
        ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    background-color: #333;
}

li {
    float: left;
}

li a {
    display: block;
    color: white;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
}

li a:hover {
    background-color: #111;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
           <div class="auto-style1>
          
&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Bauhaus 93" ForeColor="#009933" style="font-size: xx-large; text-align: center" Text="STOCK IN"></asp:Label>
        
            <br />
            <br />

    <ul class="menu">
              <li> <a href="CategoryUI.aspx">Catagory Setup</a></li>
             <li><a href="CompanyUI.aspx">Company</a></li>
             <li><a href="ItemUI.aspx">Item</a></li>
             <li><a href="StockInUI.aspx">Stock In</a></li>
            <li><a href="StockOutUI.aspx">Stock Out</a></li> 
            <li> <a href="SearchAndViewUI.aspx">Search & View</a></li>
            </ul>     

           </div>
         <br />
            <br />
    <div class="auto-style2">
    
        <asp:Label ID="Label1" runat="server" Text="Company"></asp:Label>
        <asp:DropDownList ID="companyDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="companyDropDownList_SelectedIndexChanged">
            <asp:ListItem Text="<Select Subject>" Value="0" />

        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Item"></asp:Label>
        <asp:DropDownList ID="itemDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="itemDropDownList_SelectedIndexChanged">
            <asp:ListItem Text="<Select Subject>" Value="0" />
        </asp:DropDownList>
    
        <br />
        <asp:Label ID="Label3" runat="server" Text="Reorder Level"></asp:Label>
        <asp:TextBox ID="reorderLevelTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Available Quantity"></asp:Label>
        <asp:TextBox ID="stockInTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Stock In"></asp:Label>
        <asp:TextBox ID="availableQuantityTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
    
        <br />
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
