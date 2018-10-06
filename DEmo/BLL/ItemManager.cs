using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEmo.DAL;
using DEmo.Model;

namespace DEmo.BLL
{
    public class ItemManager
    {
       ItemGeteway itemGeteway=new ItemGeteway();

        public List<Company> GetAllCompany()
        {
            return itemGeteway.GetAllCompany();

        }

        public List<Category> GetAllCategory()
        {
            return itemGeteway.GetAllCategory();
        }

        public string saveItem(Item item)
        {
            Item aItem = itemGeteway.IsExist(item);
            if (aItem==null)
            {
                int rowsAffected = itemGeteway.saveItem(item);
                if (rowsAffected > 0)
                {
                    return "Saved Successful";

                }
                else
                {
                    return "Saved Failed"; 
                }
               
            }
            else
            {
                return "not uniq";
            }

        }




    }
}