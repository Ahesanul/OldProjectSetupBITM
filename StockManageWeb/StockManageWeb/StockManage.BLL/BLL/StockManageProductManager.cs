using StockManage.Models.Models;
using StockManageWeb.repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StockManage.BLL.BLL
{
    public class StockManageProductManager
    {
        Product product = new Product();
        StockManageRepositoryProduct _Repository = new StockManageRepositoryProduct();
        public void Add(Product product, HttpPostedFileBase image)
        {
            _Repository.add(product,image);
        }
        public List<Product> Show()
        {
            return _Repository.Show();
        }

        public void Edit(Product product, HttpPostedFileBase image)
        {
            _Repository.Edit(product,image);
        }

        public void Delete(Product product)
        {
            _Repository.Delete(product);
        }

        public Product GetByID(Product product)
        {
            return _Repository.GetByID(product);
        }
        public List<Product> Search(Product product)
        {
            return _Repository.search(product);
        }
    }
}
