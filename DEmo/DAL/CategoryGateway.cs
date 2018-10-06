using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DEmo.Model;

namespace DEmo
{
    public class CategoryGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["StockMenagementBDconnectionString"].ConnectionString;

        public int SaveCategory(Category category)
        {  

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Category_t VALUES('" + category.CategoryName + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }


        public List<Category> GetAllCategories()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Category_t";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Category> categoryList = new List<Category>();
            while (reader.Read())
            {
                Category aCategory = new Category();
                aCategory.CategoryID = (int)reader["CategoryID"];
                aCategory.CategoryName = reader["CategoryName"].ToString();
                categoryList.Add(aCategory);
            }
            reader.Close();
            connection.Close();
            return categoryList;
        }

        public Category IsExist(Category category)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Category_t WHERE CategoryName='" + category.CategoryName + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Category aCategory = null;
            while (reader.Read())
            {
                aCategory = new Category();
                aCategory.CategoryID = (int)reader["CategoryID"];
                aCategory.CategoryName = reader["CategoryName"].ToString();
                
            }
            reader.Close();
            connection.Close();
            return aCategory;
        }



    }
}