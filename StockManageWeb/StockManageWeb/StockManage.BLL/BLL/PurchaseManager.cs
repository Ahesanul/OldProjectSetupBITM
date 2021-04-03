using StockManage.Models.Models;
using StockManageWeb.repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManage.BLL.BLL
{
    public class PurchaseManager
    {
       
        PurchaseRepository _Repository = new PurchaseRepository();

        public List<Product> ShowProduct()
        {
            return _Repository.ShowProduct();
        }

        public void add(List<Purchase> purchase)
        {
            _Repository.add(purchase);
        }

        public void update(List<Purchase> purchase)
        {
           _Repository.update(purchase);
        }

        public List<Supplier> ShowSupplier()
        {
            return _Repository.ShowSupplier();
        }

        public List<Purchase> totalPrice()
        {
            return _Repository.totalPrice();
        }

        public List<Purchase> GetByIDtotalPrice(int productID)
        {
            return _Repository.GetByIDtotalPrice(productID);
        }
        public List<OrderRemark> orderRemark()
        {
            return _Repository.orderRemark();
        }

    }
}
