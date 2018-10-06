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
    public partial class StockInUI : System.Web.UI.Page
    {

        private StockInManager stockInManager = new StockInManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                companyDropDownList.DataTextField = "CompanyName";
                companyDropDownList.DataValueField = "CompanyID";
                companyDropDownList.DataSource = stockInManager.GetAllCompany();
                companyDropDownList.DataBind();
                companyDropDownList.Items.Insert(0, new ListItem("<Select Subject>", "0"));
            }


        }

        protected void companyDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            itemDropDownList.DataTextField = "ItemName";
            itemDropDownList.DataValueField = "ItemID";
            itemDropDownList.DataSource = stockInManager.GetAllItems(companyId);
            itemDropDownList.DataBind();
            itemDropDownList.Items.Insert(0, new ListItem("<Select Subject>", "0"));
        }

        protected void itemDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(itemDropDownList.SelectedValue);
            Item item = stockInManager.GetReorderLevel(itemId);
            reorderLevelTextBox.Text = item.ReorderLavel.ToString();

            StockIn stockIn=new StockIn();
            stockIn.ItemID = itemId;

            
             StockIn stock = stockInManager.IsExist(stockIn);
            if (stock == null)
            {
                stockInTextBox.Text = " ";
                messageLabel.Text = "Insert Stock In";
            }
            else
            {
                StockIn aStockIn = stockInManager.GetAvailableQuantity(stockIn);
                stockInTextBox.Text = aStockIn.AvailableQuantity;
                messageLabel.Text = "Output";
            }

           



        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            StockIn stockIn = new StockIn();
            string stockInBox = stockInTextBox.Text;
            string availBox = availableQuantityTextBox.Text;

            if(string.IsNullOrWhiteSpace(stockInBox))
            {
                stockIn.ItemID = Convert.ToInt32(itemDropDownList.SelectedValue);
                stockIn.AvailableQuantity = availBox;
                messageLabel.Text = stockInManager.saveStockIn(stockIn);
            }

            else
            {
                stockIn.ItemID = Convert.ToInt32(itemDropDownList.SelectedValue);
                int first = Convert.ToInt32(availBox);
                int second = Convert.ToInt32(stockInBox);

                int result=first+second;
                stockIn.AvailableQuantity =result.ToString() ;
                messageLabel.Text = stockInManager.updateStockIn(stockIn);
            }
           


        }


    }
}