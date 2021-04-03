using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using OnlineShopWebApp.MyContext;
using OnlineShopWebApp.Model.Model;

namespace OnlineShopWebApp.DAL.Repository
{
    public class CategoryRepository
    {
        private OnlineShopManagementContext db = new OnlineShopManagementContext();
        public List<Category> GetAll()
        { 
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            Category category = new Category();
            category = db.Categories.SingleOrDefault( x => x.Id == id);
            
            /*
            var x = from c in db.Categories
                where c.Id == id
                select c;
            */
            return category;
        }

        public int Create(Category category)
        {
            db.Categories.Add(category);
             int executed = db.SaveChanges();
            return executed;
        }

        public int update(Category category)
        {
            Category upCategory = this.GetById(category.Id);
            upCategory.CategoryName = category.CategoryName;
            upCategory.Code = category.Code;
            upCategory.Products = category.Products;


            int executed =db.SaveChanges();
            return executed;
        }

        public int Delete(int id)
        {
            Category category = new Category();
            category = db.Categories.SingleOrDefault(x => x.Id == id);
            db.Categories.Remove(category);
            int executed  = db.SaveChanges();
            
            return executed;
        }


    }
}
