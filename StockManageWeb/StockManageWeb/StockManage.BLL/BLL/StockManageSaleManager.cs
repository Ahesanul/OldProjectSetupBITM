using StockManage.Models.Models;
using StockManageWeb.repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManage.BLL.BLL
{
    public class StockManageSaleManager
    {
        Sale sells = new Sale();
        StockManageSaleRepository _Repository = new StockManageSaleRepository();
        public bool Add(List<Sale> sales)
        {
           return _Repository.add(sales);
        }
        public List<Customer> Show()
        {
            return _Repository.Show();
        }

        public List<Purchase> ShowProduct()
        {
            return _Repository.ShowProduct();
        }

        public int GetByID(int customerID)
        {
            return _Repository.GetByID(customerID);
        }

        public int GetbyIDReorder(int productID)
        {
            return _Repository.GetByID(productID);
        }
        public int GetByID2(int productID)
        {
            return _Repository.GetByID2(productID);
        }
    }
}
