using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEmo.Model
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CompanyID { get; set; }
        public int CategoryID { get; set; }
        public int ReorderLavel { get; set; }
    }
}