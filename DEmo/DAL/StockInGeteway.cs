using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DEmo.Model;

namespace DEmo.DAL
{
    public class StockInGeteway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["StockMenagementBDconnectionString"].ConnectionString;
        CompanyGeteway companyGeteway = new CompanyGeteway();





        public List<Company> GetAllCompany()
        {
            return companyGeteway.GetAllCompany();
        }

        public List<Item> GetItems(int companyID)
        {   
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Item_t INNER JOIN Company_t ON Item_t.CompanyID=Company_t.CompanyID Where Company_t.CompanyID='"+companyID+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Item> itemList = new List<Item>();
            while (reader.Read())
            {
                Item item=new Item();
                item.ItemID = (int) reader["ItemID"];
                item.ItemName = reader["ItemName"].ToString();
                item.CompanyID = (int) reader["CompanyID"];
                item.CategoryID = (int) reader["CategoryID"];
               

                itemList.Add(item);
            }
            reader.Close();
            connection.Close();
            return itemList;
        }

        public Item GetReorderLevel(int itemID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Item_t WHERE ItemID='" + itemID + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Item aItem = null;
            while (reader.Read())
            {
                aItem = new Item();


                aItem.ItemName = reader["ItemName"].ToString();
                aItem.CategoryID = (int)reader["CategoryID"];
                aItem.CompanyID = (int)reader["CompanyID"];
                aItem.ReorderLavel = (int)reader["ReorderLevel"];

            }
            reader.Close();
            connection.Close();
            return aItem;
        }


        public StockIn GetAvailableQuantity(StockIn stockIn)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM StockIn_t WHERE ItemID='" + stockIn.ItemID + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            StockIn stock = null;
            while (reader.Read())
            {
                stock = new StockIn();


                stock.StockID =(int) reader["StockInID"];
                stock.AvailableQuantity = reader["AvailableQuantity"].ToString();
                stock.ItemID = (int)reader["ItemID"];

            }
            reader.Close();
            connection.Close();
            return stock;
        }

        public StockIn IsExist(StockIn stockIn)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select AvailableQuantity from StockIn_t where ItemId='" + stockIn.ItemID + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            StockIn stock = null;
            if (reader.HasRows)
            {
                reader.Read();
                stock = new StockIn();

                stock.AvailableQuantity = reader["AvailableQuantity"].ToString();

            }
            reader.Close();
            connection.Close();
            return stock;
        }

        public int saveStockIn(StockIn stockIn)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO StockIn_t VALUES('" + stockIn.AvailableQuantity + "','" +stockIn.ItemID + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }


        public int updateStockIn(StockIn stock)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Update StockIn_t Set AvailableQuantity ='" + stock.AvailableQuantity + "' Where ItemID='" + stock.ItemID + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }


    }
}