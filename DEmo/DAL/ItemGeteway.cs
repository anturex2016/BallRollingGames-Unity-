using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DEmo.Model;

namespace DEmo.DAL
{
    public class ItemGeteway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["StockMenagementBDconnectionString"].ConnectionString;

        CompanyGeteway companyGeteway=new CompanyGeteway();
        CategoryGateway categoryGateway=new CategoryGateway();

        public List<Company> GetAllCompany()
        {
           return companyGeteway.GetAllCompany();
        }

        public List<Category> GetAllCategory()
        {
            return categoryGateway.GetAllCategories();
        }

        public int saveItem(Item item)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Item_t VALUES('" + item.ItemName + "','"+item.CompanyID+"','"+item.CategoryID+"','"+item.ReorderLavel+"')";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }

        public Item IsExist(Item item)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Item_t WHERE ItemName='" + item.ItemName + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Item aItem = null;
            while (reader.Read())
            {
                aItem = new Item();
                aItem.ItemID = (int)reader["ItemID"];
                
                aItem.ItemName = reader["ItemName"].ToString();
                aItem.CategoryID = (int)reader["CategoryID"];
                aItem.CompanyID = (int)reader["CompanyID"];
                aItem.ReorderLavel = (int) reader["ReorderLevel"];

            }
            reader.Close();
            connection.Close();
            return aItem;
        }
    }
}