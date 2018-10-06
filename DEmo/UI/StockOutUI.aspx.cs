using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DEmo.BLL;
using DEmo.Model;

namespace DEmo.UI
{
    public partial class StockOutUI : System.Web.UI.Page
    {
        StockOutManager stockOutManager=new StockOutManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                companyDropDownList.DataTextField = "CompanyName";
                companyDropDownList.DataValueField = "CompanyID";
                companyDropDownList.DataSource = stockOutManager.GetAllCompany();
                companyDropDownList.DataBind();
                companyDropDownList.Items.Insert(0, new ListItem("<Select Subject>", "0"));

                int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
                int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
                string sellQuantity = stockOutTextBox.Text;

            
             

              
            }
        }

        protected void companyDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            itemDropDownList.DataTextField = "ItemName";
            itemDropDownList.DataValueField = "ItemID";
            itemDropDownList.DataSource = stockOutManager.GetAllItems(companyId);
            itemDropDownList.DataBind();
            itemDropDownList.Items.Insert(0, new ListItem("<Select Subject>", "0"));
        }

        protected void itemDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
            Item item =stockOutManager.GetReorderLevel(itemId);
            reorderLevelTextBox.Text = item.ReorderLavel.ToString();

            //this code is for available quantity////////////

            StockIn stockIn = new StockIn();
            stockIn.ItemID = itemId;
            StockIn stock = stockOutManager.IsExist(stockIn);
            if (stock == null)
            {
                stockOutTextBox.Text = " ";
                messageLabel.Text = "Empty Available Quantity";
            }
            else
            {
                StockIn aStockIn = stockOutManager.GetAvailableQuantity(stockIn);
                stockOutTextBox.Text = aStockIn.AvailableQuantity;
            }

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            List<StockOut> stockOutItems = new List<StockOut>();
            if (Session["items"] != null)
            {
                stockOutItems = (List<StockOut>)Session["items"];
            }
            StockOut stockOut=new StockOut();
            stockOut.CompanyName = companyDropDownList.SelectedItem.Text;
            stockOut.ItemName = itemDropDownList.SelectedItem.Text;
            stockOut.SellQuantity= availableQuantityTextBox.Text;
            stockOutItems.Add(stockOut);
            //stockOutItems = stockOutManager.GetAllStockOut(itemId, companyId, sellQuantity);
            GridView.DataSource=stockOutItems;
            GridView.DataBind();
            Session["items"] = stockOutItems;

            stockOut.SellQuantity = " ";

        }

        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblSerial = (Label)e.Row.FindControl("lblSerial");
                lblSerial.Text = ((GridView.PageIndex * GridView.PageSize) + e.Row.RowIndex + 1).ToString();
            }
        }

        protected void compaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CategoryUI.aspx");
        }

        protected void catButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyUI.aspx");
        }

        protected void itemButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ItemUI.aspx");
        }

        protected void stockInButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StockInUI.aspx");
        }

        protected void stockOutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StockOutUI.aspx");
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchAndViewUI.aspx");
        }




    }
}