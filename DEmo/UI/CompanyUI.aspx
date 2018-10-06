<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyUI.aspx.cs" Inherits="DEmo.UI.CompanyUI" %>

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
      .panel
{
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
  
&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Bauhaus 93" ForeColor="#009933" style="font-size: xx-large; text-align: center" Text="COMPANY"></asp:Label>
           
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
        <br />
        <br />
   
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        <br />
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
        <br />
        <div class="div3">
             <asp:GridView ID="GridView" CssClass="panel" runat="server" OnRowDataBound="GridView_RowDataBound" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="sl.no">
                        <ItemTemplate>
                          <asp:Label ID="lblSerial" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Company Name">
                        <ItemTemplate>
                            <%#Eval("CompanyName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
      
        
   
    </div>
    </form>
</body>
</html>
