using StockManage.DatabaseContext.DatabaseContext;
using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManageWeb.repository.Repository
{
    public class PurchaseRepository
    {
        StockManageDbContext Db = new StockManageDbContext();
        public void add(List<Purchase> purchase)
        {
            Db.purchases.AddRange(purchase);
            Db.SaveChanges();
        }

        public List<Product> ShowProduct()
        {
            return Db.products.ToList();
        }

        public List<Supplier> ShowSupplier()
        {
            return Db.suppliers.ToList();
        }

        public void update(List<Purchase> purchase)
        {
            foreach (var item in purchase)
            {
                Purchase apurchase = Db.purchases.FirstOrDefault(x => x.ID == item.ID);
                apurchase = item;

                Db.SaveChanges();
            }
           
           
        }

        public List<Purchase> totalPrice()
        {
            var customers = Db.purchases.ToList();

            return customers;
        }

        public List<Purchase> GetByIDtotalPrice(int productID)
        {
            var customers = Db.purchases.ToList();

            return customers;
        }

        public List<OrderRemark> orderRemark()
        {
            var customers = Db.orderRemarks.ToList();

            return customers;
        }
        
    }
}
