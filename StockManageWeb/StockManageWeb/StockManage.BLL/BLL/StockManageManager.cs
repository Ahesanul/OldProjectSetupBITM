using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManageWeb.repository.Repository;

namespace StockManage.BLL.BLL
{
    public class StockManageManager
    {
        Category category = new Category();
        StockManageRepository _Repository = new StockManageRepository();
        public void Add(Category category)
        {
             _Repository.add(category);
        }
        public List<Category> Show()
        {
            return _Repository.Show();
        }

        public void Edit(Category category)
        {
            _Repository.Edit(category);
        }

        public void Delete(Category category)
        {
            _Repository.Delete(category);
        }

        public Category GetByID(Category category)
        {
            return _Repository.GetByID(category);
        }
        
    }
}
