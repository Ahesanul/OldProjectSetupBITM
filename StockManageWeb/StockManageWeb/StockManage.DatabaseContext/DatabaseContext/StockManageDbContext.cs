using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StockManage.Models.Models;

namespace StockManage.DatabaseContext.DatabaseContext
{
    public class StockManageDbContext : DbContext
    {
        public DbSet<Category> categories { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Sale> sales { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<OrderRemark> orderRemarks { get; set; }

    }
}
