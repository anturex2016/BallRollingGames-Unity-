using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEmo.DAL;
using DEmo.Model;

namespace DEmo.BLL
{
    public class StockOutManager
    {
        StockOutGeteway stockOutGeteway=new StockOutGeteway();

        public List<Company> GetAllCompany()
        {
            return stockOutGeteway.GetAllCompany();
        }

        public List<Item> GetAllItems(int companyID)
        {
            return stockOutGeteway.GetItems(companyID);
        }

        public Item GetReorderLevel(int itemId)
        {
            return stockOutGeteway.GetReorderLevel(itemId);
        }

        public StockIn GetAvailableQuantity(StockIn stock)
        {
            return stockOutGeteway.GetAvailableQuantity(stock);
        }

        public StockIn IsExist(StockIn stockIn)
        {
            return stockOutGeteway.IsExist(stockIn);
        }


        //public List<StockOut> GetAllStockOut(int itemID, int companyID,string sellQuantity)
        //{
        //    return stockOutGeteway.GetAllStockOut(itemID, companyID, sellQuantity);
        //}



    }
}