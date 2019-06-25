using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace LanesOnlineStore.Models
{
    public class LanesOnlineStoreEntities : DbContext
    {
        public LanesOnlineStoreEntities()
            : base("Name=LanesOnlineStore")
        { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerData> Customers { get; set; }
        public DbSet<CustomerOrders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }


    }
}