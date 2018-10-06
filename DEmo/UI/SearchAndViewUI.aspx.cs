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
    public partial class SearchAndViewUI : System.Web.UI.Page
    {
        SearchAndViewManager searchAndViewManager=new SearchAndViewManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                companyDropDownList.DataTextField = "CompanyName";
                companyDropDownList.DataValueField = "CompanyID";

                companyDropDownList.DataSource = searchAndViewManager.GetAllCompany();
                companyDropDownList.DataBind();

                categoryDropDownList.DataTextField = "CategoryName";
                categoryDropDownList.DataValueField = "categoryID";
                categoryDropDownList.DataSource = searchAndViewManager.GetAllCategory();
                categoryDropDownList.DataBind();
            }
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {

            //Item item = new Item();
            //item.ItemName = itemNameTextBox.Text;
            //item.ReorderLavel = Convert.ToInt32(reorderLevelTextBox.Text);
            int CompanyID = Convert.ToInt32(companyDropDownList.SelectedValue);
            int CategoryID = Convert.ToInt32(categoryDropDownList.SelectedValue);

            searchGridView.DataSource = searchAndViewManager.GetSearchResult(CompanyID, CategoryID);
            searchGridView.DataBind();


        }
    }
}