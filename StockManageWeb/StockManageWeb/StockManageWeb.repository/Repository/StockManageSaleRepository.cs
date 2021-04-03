using StockManage.DatabaseContext.DatabaseContext;
using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManageWeb.repository.Repository
{
    public class StockManageSaleRepository
    {

        StockManageDbContext Db = new StockManageDbContext();

 
        public bool add(List <Sale> sales)
        {
           
            Db.sales.AddRange(sales);

            return Db.SaveChanges() > 0;
        }
        public List<Customer> Show()
        {
            return Db.customers.ToList();
        }
        public List<Purchase> ShowProduct()
        {
            return Db.purchases.ToList();
        }
        public int GetByID(int cutomerID)
        {
            var customers = Db.customers.Where(c=>c.ID== cutomerID).Select(c=>c.Loyalty).SingleOrDefault();

            return customers;
        }

        public int GetbyIDReorder(int productID)
        {
            var customers = Db.purchases.Where(c => c.ID == productID).Select(c => c.product.ReorderLevel).SingleOrDefault();

            return customers;
        }

        public int GetByID2(int productID)
        {
            var customers = Db.purchases.Where(c => c.ID == productID).Select(c => c.quantity).SingleOrDefault();

            return customers;
        }
    }
}
