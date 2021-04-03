using StockManage.DatabaseContext.DatabaseContext;
using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StockManageWeb.repository.Repository
{
    public class StockManageSupplierRipository
    {

        StockManageDbContext Db = new StockManageDbContext();

        public int add(Supplier supplier, HttpPostedFileBase image)
        
        {
            using (BinaryReader br = new BinaryReader(image.InputStream))
            {

                supplier.Data = br.ReadBytes(image.ContentLength);
            }

            Db.suppliers.Add(supplier);
          
            int saved = Db.SaveChanges();
            return 0;
        }
        public List<Supplier> Show()
        {

            return Db.suppliers.ToList();

        }

        public int Edit(Supplier supplier)
        {
            Supplier aSupplier= Db.suppliers.FirstOrDefault(x => x.ID == supplier.ID);
            aSupplier.Name = supplier.Name;
            aSupplier.Code = supplier.Code;
            aSupplier.Address = supplier.Address;
            aSupplier.Email = supplier.Email;
            aSupplier.Contact = supplier.Contact;
            aSupplier.ContactPerson = supplier.ContactPerson;

            Db.SaveChanges();
            return 0;
        }

        public int Delete(Supplier supplier)
        {
            Supplier aSupplier = Db.suppliers.FirstOrDefault(x => x.ID == supplier.ID);
            Db.suppliers.Remove(aSupplier);
            Db.SaveChanges();
            return 0;
        }

        public Supplier GetByID(Supplier supplier)
        {
            Supplier aSupplier = Db.suppliers.FirstOrDefault(c => c.ID == supplier.ID);
            return aSupplier;
        }
    }
}
