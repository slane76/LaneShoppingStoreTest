using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanesOnlineStore
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QTYPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}