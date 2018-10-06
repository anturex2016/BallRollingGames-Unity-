<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="DEmo.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
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
        <div class="auto-style1">
    <div>
        <img src="purchase-guy.png" width="200px" height="200px" alt="Alternate Text" />
    </div>

            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Bauhaus 93" ForeColor="#009933" style="font-size: xx-large; text-align: center" Text="STOCK MANAGEMENT SYSTEM"></asp:Label>
            <br />
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
    </form>
</body>
</html>
