using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using DEmo.DAL;

namespace DEmo.Model
{
    public class StockOutGeteway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["StockMenagementBDconnectionString"].ConnectionString;
        CompanyGeteway companyGeteway = new CompanyGeteway();
        StockInGeteway stockInGeteway=new StockInGeteway();

        public List<Company> GetAllCompany()
        {
            return companyGeteway.GetAllCompany();
        }

        public List<Item> GetItems(int companyID)
        {
            return stockInGeteway.GetItems(companyID);
        }

        public Item GetReorderLevel(int itemID)
        {
            return stockInGeteway.GetReorderLevel(itemID);
        }

        public StockIn GetAvailableQuantity(StockIn stockIn)
        {
            return stockInGeteway.GetAvailableQuantity(stockIn);
        }

        public StockIn IsExist(StockIn stockIn)
        {
            return stockInGeteway.IsExist(stockIn);
        }

        //public string GetItemName(int itemId)
        //{
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    string query = "SELECT ItemName FROM Item_t WHERE ItemID='"+itemId+"'";
        //    SqlCommand command = new SqlCommand(query, connection);

        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //   Item item=new Item();
        //    while (reader.Read())
        //    {
                
        //        //item.ItemID = (int)reader["ItemID"];
        //         item.ItemName = reader["ItemName"].ToString();
                
        //    }
        //    reader.Close();
        //    connection.Close();
        //    return item.ItemName;
        //}

        //public String GetCompanyName(int companyID)
        //{
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    string query = "SELECT CompanyName FROM Company_t WHERE CompanyID='"+companyID+"'";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();

        //    Company acompany = new Company();
        //    while (reader.Read())
        //    {
               
        //        //acompany.CompanyID = (int)reader["CompanyID"];
        //        acompany.CompanyName = reader["CompanyName"].ToString();

                
        //    }
        //    reader.Close();
        //    connection.Close();
        //    return acompany.CompanyName;
        //}


        //public List<StockOut> GetAllStockOut(int itemId,int companyId, string sellQuantity)
        //{
        //    List<StockOut>stockOutList=new List<StockOut>();
        //    StockOut stock=new StockOut();
        //    stock.ItemName = GetItemName(itemId);
        //    stock.CompanyName = GetCompanyName(companyId);
        //    stock.SellQuantity = sellQuantity;
        //    stockOutList.Add(stock);

           

        //    return stockOutList;
        

















    }
}