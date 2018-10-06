using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEmo.UI
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CategoryUI.aspx");

        }

        protected void companyButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyUI.aspx");
        }

        protected void itemButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("IndexUI.aspx");
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}