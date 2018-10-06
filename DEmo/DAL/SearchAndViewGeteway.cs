using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DEmo.Model;

namespace DEmo.DAL
{
    public class SearchAndViewGeteway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["StockMenagementBDconnectionString"].ConnectionString;

        CompanyGeteway companyGeteway = new CompanyGeteway();
        CategoryGateway categoryGateway = new CategoryGateway();

        public List<Company> GetAllCompany()
        {
            return companyGeteway.GetAllCompany();
        }
        public List<Category> GetAllCategory()
        {
            return categoryGateway.GetAllCategories();
        }


        public List<SearchAndView> GetSearchResult(int companyID,int categoryId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Item_t.ItemName, Company_t.CompanyName,Category_t.CategoryName,StockIn_t.AvailableQuantity,Item_t.ReorderLevel FROM ((Item_t INNER JOIN Company_t ON Company_t.CompanyID = Item_t.CompanyID) INNER JOIN Category_t ON  Item_t.CategoryID=Category_t.CategoryID INNER JOIN StockIn_t ON Item_t.ItemID=StockIn_t.ItemID) WHERE CompanyID='"+companyID+"' AND CategoryID='"+categoryId+"'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<SearchAndView>searchList=new List<SearchAndView>();
          
            while (reader.Read())
            {
              SearchAndView searchAndView = new SearchAndView();


                searchAndView.ItemName = reader["ItemName"].ToString();
                searchAndView.CompanyName = reader["CompanyName"].ToString();
                searchAndView.CategoryName = reader["Categoryname"].ToString();
                searchAndView.AvailavleQuntity= reader["AvailableQuantity"].ToString();
                searchAndView.ReorderLevel = (int)reader["Reorderlevel"];
                searchList.Add(searchAndView);
            }
            reader.Close();
            connection.Close();
            return searchList;
        }
    }
}