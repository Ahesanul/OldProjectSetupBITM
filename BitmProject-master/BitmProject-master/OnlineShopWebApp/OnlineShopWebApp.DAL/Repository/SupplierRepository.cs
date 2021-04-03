using OnlineShopWebApp.MyContext;
using OnlineShopWebApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopWebApp.DAL.Repository
{
    public class SupplierRepository
    {

        private OnlineShopManagementContext db = new OnlineShopManagementContext();
        public List<Supplier> GetAll()
        {
            return db.Suppliers.ToList();
        }

        public Supplier GetById(int id)
        {
            Supplier supplier = new Supplier();
            supplier = db.Suppliers.SingleOrDefault(x => x.ID == id);

            /*
            var x = from c in db.Categories
                where c.Id == id
                select c;
            */
            return supplier;
        }

        public int Create(Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            int executed = db.SaveChanges();
            return executed;
        }

        public int update(Supplier supplier)
        {
            Supplier upsupplier = this.GetById(supplier.ID);
            upsupplier.Code = supplier.Code;
            upsupplier.Address = supplier.Address;
            upsupplier.Contact = supplier.Contact;
            upsupplier.ContactPerson = supplier.ContactPerson;
            upsupplier.Email = supplier.Email;
            upsupplier.Name = supplier.Name;
            

            int executed = db.SaveChanges();
            return executed;
        }

        public int Delete(int id)
        {
            Supplier supplier = new Supplier();
            supplier = db.Suppliers.SingleOrDefault(x => x.ID == id);
            db.Suppliers.Remove(supplier);
            int executed = db.SaveChanges();

            return executed;
        }

    }
}
