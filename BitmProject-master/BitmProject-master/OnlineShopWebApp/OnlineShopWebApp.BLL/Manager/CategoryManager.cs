using OnlineShopWebApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopWebApp.DAL.Repository;

namespace OnlineShopWebApp.BLL.Manager
{
    public class CategoryManager
    {
        private CategoryRepository db = new CategoryRepository();
        public List<Category> GetAll()
        {
            return db.GetAll();
        }

        public Category GetById(int id)
        {
            return db.GetById( id);
        }

        public int Create(Category category)
        {
            return db.Create( category);
        }

        public int update(Category category)
        {
            return db.update( category);
        }

        public int Delete(int id)
        {
            return db.Delete( id);
        }

    }
}
