using System;
using System.Collections.Generic;
using System.Linq;
using OnlineShopWebApp.MyContext;
using System.Text;
using System.Threading.Tasks;
using OnlineShopWebApp.Model.Model;

namespace OnlineShopWebApp.DAL.Repository
{
    public class ProductRepository
    {

        private OnlineShopManagementContext db = new OnlineShopManagementContext();
        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            Product product = new Product();
            product = db.Products.SingleOrDefault(x => x.Id == id);

            /*
            var x = from c in db.Categories
                where c.Id == id
                select c;
            */
            return product;
        }

        public int Create(Product product)
        {
            db.Products.Add(product);
            int executed = db.SaveChanges();
            return executed;
        }

        public int update(Product product)
        {
            Product upProduct = this.GetById(product.Id);
            upProduct.ProductName = product.ProductName;
            upProduct.Code = product.Code;
            upProduct.Description = product.Description;
            upProduct.ReOrderQuantity = product.ReOrderQuantity;

            int executed = db.SaveChanges();
            return executed;
        }

        public int Delete(int id)
        {
            Product product = new Product();
            product = db.Products.SingleOrDefault(x => x.Id == id);
            db.Products.Remove(product);
            int executed = db.SaveChanges();

            return executed;
        }

    }
}
