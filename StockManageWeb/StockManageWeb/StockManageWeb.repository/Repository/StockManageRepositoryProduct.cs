using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManage.DatabaseContext.DatabaseContext;
using StockManage.Models.Models;
using System.Data.Entity;
using System.IO;
using System.Web;

namespace StockManageWeb.repository.Repository
{
    public class StockManageRepositoryProduct
    {
        StockManageDbContext Db = new StockManageDbContext();

        public int add(Product product, HttpPostedFileBase image)
        {


            using (BinaryReader br = new BinaryReader(image.InputStream))
            {

                product.Data = br.ReadBytes(image.ContentLength);
            }

            Db.products.Add(product);
            int saved = Db.SaveChanges();
            return 0;
        }
        public List<Product> Show()
        {

            return Db.products.ToList();

        }

        public int Edit(Product product, HttpPostedFileBase image)
        {
            
            Product aProduct = Db.products.FirstOrDefault(x => x.ID == product.ID);
            aProduct.Name = product.Name;
            aProduct.Code = product.Code;
            aProduct.CategoryID = product.CategoryID;
            aProduct.Discription = product.Discription;
            aProduct.ReorderLevel = product.ReorderLevel;

            using (BinaryReader br = new BinaryReader(image.InputStream))
            {

                product.Data = br.ReadBytes(image.ContentLength);
            }
            aProduct.Data = product.Data;
            Db.SaveChanges();
            return 0;
        }

        public int Delete(Product product)
        {
            Product aProduct = Db.products.FirstOrDefault(x => x.ID == product.ID);
            Db.products.Remove(aProduct);
            Db.SaveChanges();
            return 0;
        }

        public Product GetByID(Product product)
        {
            Product aProduct = Db.products.FirstOrDefault(c => c.ID == product.ID);
            return aProduct;
        }

        public List<Product> search(Product product)
        {
            return Db.products.Where(c => c.Name.ToLower().Contains(product.Name.ToLower())).ToList();
        }
    }
}
