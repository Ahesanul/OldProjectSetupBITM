using StockManage.DatabaseContext.DatabaseContext;
using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManageWeb.repository.Repository
{
    public class SotckRepository
    {
        StockManageDbContext Db = new StockManageDbContext();

        public List<Sale> sales()
        {
            return Db.sales.ToList();
        }
        public List<Product> ShowProduct()
        {
            return Db.products.ToList();
        }
    }
}
