using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopWebApp.Model.Model;
using OnlineShopWebApp.DAL.Repository;

namespace OnlineShopWebApp.BLL.Manager
{
    public class ProductManager
    {
        private ProductRepository db = new ProductRepository();
        public List<Product> GetAll()
        {
            return db.GetAll();
        }

        public Product GetById(int id)
        {

            return db.GetById( id);
        }

        public int Create(Product product)
        {
           
            return db.Create( product);
        }

        public int update(Product product)
        {

            return db.update( product);
        }

        public int Delete(int id)
        {
            return db.Delete( id);
        }

    }
}
