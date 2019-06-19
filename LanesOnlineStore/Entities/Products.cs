using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanesOnlineStore.Entities
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int ProductOnhand { get; set; }
        public string Category { get; set; }
        public int ProductRating { get; set; }


    }
}