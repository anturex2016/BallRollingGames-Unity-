using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEmo.Model
{
    public class StockIn
    {
        public int StockID { get; set; }
        public string AvailableQuantity { get; set; }
        //public string Date { get; set; }
        //public int CompanyID { get; set; }
        public int ItemID { get; set; }
    }
}