using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EC_MVC.Models
{
    public class OrderDbContext : DbContext
    {
        public DbSet<ExampleOrder> ExampleOrders { get; set; }
    }
}