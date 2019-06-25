using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanesOnlineStore.Models
{
    public class CustomerOrders
    {
        public int CustomerIDNumber { get; set; }
        public int OrderNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemNumber { get; set; }
        public decimal UnitQTY { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalOrderCost { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string PaymentType { get; set; }
        public string InStock { get; set; }

    }
}