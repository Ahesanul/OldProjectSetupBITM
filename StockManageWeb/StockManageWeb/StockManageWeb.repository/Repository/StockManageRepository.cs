using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManage.DatabaseContext.DatabaseContext;
using StockManage.Models.Models;
using System.Data.Entity;

namespace StockManageWeb.repository.Repository
{
    public class StockManageRepository
    {
        StockManageDbContext Db = new StockManageDbContext();
        public int add(Category category)
        {
            Db.categories.Add(category);
            int saved = Db.SaveChanges();
            return 0;
        }
        public List<Category> Show()
        {

            return  Db.categories.ToList();
           
        }

        public int Edit(Category category)
        {
            Category aCategory = Db.categories.FirstOrDefault(x => x.ID == category.ID);
            aCategory.Name= category.Name;
            aCategory.Code = category.Code;
           
            Db.SaveChanges();
            return 0;
        }

        public int Delete(Category category)
        {
            Category aCategory = Db.categories.Single(x => x.ID == category.ID);
            Db.categories.Remove(aCategory);
            Db.SaveChanges();
            return 0;
        }

        public Category GetByID(Category category)
        {
            Category aCategory = Db.categories.FirstOrDefault(c => c.ID == category.ID);
            return aCategory;
        }

        

    }
}
