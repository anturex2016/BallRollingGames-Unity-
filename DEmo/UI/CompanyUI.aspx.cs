using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using DEmo.BLL;
using DEmo.Model;


namespace DEmo.UI
{
    public partial class CompanyUI : System.Web.UI.Page
    {
        CompanyManager companyManager=new CompanyManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView.DataSource = companyManager.GetAllCompany();
            GridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            
            Company company = new Company();
            string nametex = nameTextBox.Text;
            company.CompanyName = nametex;

            if (string.IsNullOrWhiteSpace(nametex))
            {
                nameTextBox.Text = " ";
                messageLabel.Text = "Empty Not Accepted ";
            }
            else
            {
                messageLabel.Text = companyManager.saveCompany(company);
                GridView.DataSource = companyManager.GetAllCompany();
                GridView.DataBind();
            }
           

        }

        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblSerial = (Label)e.Row.FindControl("lblSerial");
                lblSerial.Text = ((GridView.PageIndex * GridView.PageSize) + e.Row.RowIndex + 1).ToString();
            }
        }

        protected void categoryButton_Click(object sender, EventArgs e)
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

       
        }
    }
