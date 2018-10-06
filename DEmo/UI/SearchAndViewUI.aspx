<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchAndViewUI.aspx.cs" Inherits="DEmo.UI.SearchAndViewUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2{text-align: center;}
        .panel{
             width: 330px;
             padding: 10px;
             min-height: 20px;
             border: 1px solid #dcdcdc;
             margin-left:auto;
             margin-right:auto;
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
          <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Bauhaus 93" ForeColor="#009933" style="font-size: xx-large; text-align: center" Text="SEARCH AND VIEW"></asp:Label>
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
        </div >

     <div class="auto-style2">
           <asp:Label ID="Label1" runat="server" Text="Company"></asp:Label>
        <asp:DropDownList ID="companyDropDownList" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label>
        <asp:DropDownList ID="categoryDropDownList" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="searchButton" runat="server" OnClick="searchButton_Click" Text="Search" />
        <br />
        <asp:GridView CssClass="panel"  ID="searchGridView" runat="server">
        </asp:GridView>
     </div>
      
    </form>
</body>
</html>
