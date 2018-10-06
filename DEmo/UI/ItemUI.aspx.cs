using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DEmo.BLL;
using DEmo.Model;

namespace DEmo
{
    public partial class ItemUI : System.Web.UI.Page
    {

        ItemManager itemManager=new ItemManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                companyDropDownList.DataTextField = "CompanyName";
                companyDropDownList.DataValueField = "CompanyID";

                companyDropDownList.DataSource = itemManager.GetAllCompany();
                companyDropDownList.DataBind();

                categoryDropDownList.DataTextField = "CategoryName";
                categoryDropDownList.DataValueField = "categoryID";
                categoryDropDownList.DataSource = itemManager.GetAllCategory();
                categoryDropDownList.DataBind();
            }
          


        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Item item=new Item();
            item.ItemName = itemNameTextBox.Text;
            item.ReorderLavel = Convert.ToInt32(reorderLevelTextBox.Text);
            item.CompanyID =Convert.ToInt32(companyDropDownList.SelectedValue);
            item.CategoryID = Convert.ToInt32(categoryDropDownList.SelectedValue);

            messageLabel.Text = itemManager.saveItem(item);
        }
    }
}