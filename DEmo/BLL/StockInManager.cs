using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEmo.DAL;
using DEmo.Model;

namespace DEmo.BLL
{
    public class StockInManager
    {
        StockInGeteway stockInGeteway=new StockInGeteway();

        public List<Company> GetAllCompany()
        {
            return stockInGeteway.GetAllCompany();
        }

        public List<Item> GetAllItems(int companyID)
        {
            return stockInGeteway.GetItems(companyID);
        }

        public Item GetReorderLevel(int itemId)
        {
            return stockInGeteway.GetReorderLevel(itemId);
        }

        public string saveStockIn(StockIn stockIn)
        {
            int rowsAffected = stockInGeteway.saveStockIn(stockIn);
            if (rowsAffected > 0)
            {
                return "Saved Successful";

            }
            else
            {
                return "Saved Failed";
            }
        }


        public StockIn IsExist(StockIn stockIn)
        {
            return stockInGeteway.IsExist(stockIn);
            //if (stock==null)
            //{
            //    return "Insert Available Quantity";
                
            //}
            //else
            //{
            //    return "Previous Available Quantity";

            //}
        }

        public StockIn GetAvailableQuantity(StockIn stock)
        {
            return stockInGeteway.GetAvailableQuantity(stock);
        }


        public string updateStockIn(StockIn stockIn)
        {
            int rowsAffected = stockInGeteway.updateStockIn(stockIn);
            if (rowsAffected > 0)
            {
                return "Update Successful";

            }
            else
            {
                return "Update Unsuccessful";
            }
        }

    }
}