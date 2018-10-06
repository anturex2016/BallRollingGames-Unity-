using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using DEmo.BLL;

namespace DEmo.UI
{
    public partial class CategoryUI : System.Web.UI.Page
    {
       
        CategoryManager categoryManager=new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView.DataSource = categoryManager.GetAllCategory();
            GridView.DataBind();

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Category category=new Category();
            string nametex = nameTextBox.Text;
            category.CategoryName = nametex;
            if ( string.IsNullOrWhiteSpace(nametex))
            {
                nameTextBox.Text = " ";
                messageLabel.Text = "Empty Not Accepted";
            }
            else
            {
                messageLabel.Text = categoryManager.saveCategory(category);

                GridView.DataSource = categoryManager.GetAllCategory();
                GridView.DataBind();
            }
           

        }

        protected void GridView_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblSerial = (Label)e.Row.FindControl("lblSerial");
                lblSerial.Text = ((GridView.PageIndex * GridView.PageSize) + e.Row.RowIndex + 1).ToString();
            }
        }

      
       

       
       

     

       
    }
}