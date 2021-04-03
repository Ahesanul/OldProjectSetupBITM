using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopWebApp.DAL.Repository;
using OnlineShopWebApp.Model.Model;

namespace OnlineShopWebApp.BLL.Manager
{
    public class SupplierManager
    {

        private SupplierRepository db = new SupplierRepository();
        public List<Supplier> GetAll()
        {
            return db.GetAll();
        }

        public Supplier GetById(int id)
        {

            return db.GetById( id);
        }

        public int Create(Supplier supplier)
        {
            return db.Create( supplier);
        }

        public int update(Supplier supplier)
        {
           
            return db.update( supplier);
        }

        public int Delete(int id)
        {
            return db.Delete( id);
        }

    }
}
