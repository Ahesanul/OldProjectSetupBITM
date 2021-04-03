using StockManage.Models.Models;
using StockManageWeb.repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManage.BLL.BLL
{
    public class StockManager
    {
        SotckRepository _Repository = new SotckRepository();
        public List<Sale> sales()
        {
            return _Repository.sales();
        }
        public List<Product> ShowProduct()
        {
            return _Repository.ShowProduct();
        }
    }
}
