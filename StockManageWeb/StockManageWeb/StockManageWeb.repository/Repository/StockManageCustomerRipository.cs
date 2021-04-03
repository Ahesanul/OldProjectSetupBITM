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
    public class StockManageCustomerRipository
    {
        StockManageDbContext Db = new StockManageDbContext();

        public int add(Customer customer, HttpPostedFileBase image)
        {
            
            using (BinaryReader br = new BinaryReader(image.InputStream))
            {

                customer.Data = br.ReadBytes(image.ContentLength);
            }
            Db.customers.Add(customer);
            int saved = Db.SaveChanges();
            return 0;
        }
        public List<Customer> Show()
        {

            return Db.customers.ToList();

        }

        public int Edit(Customer customer)
        {
            Customer aCustomer= Db.customers.FirstOrDefault(x => x.ID == customer.ID);
            aCustomer.Name = customer.Name;
            aCustomer.Code = customer.Code;
            aCustomer.Address = customer.Address;
            aCustomer.Email= customer.Email;
            aCustomer.Contact = customer.Contact;
            aCustomer.Loyalty = customer.Loyalty;

            Db.SaveChanges();
            return 0;
        }

        public int Delete(Customer customer)
        {
            Customer aCustomer = Db.customers.FirstOrDefault(x => x.ID == customer.ID);
            Db.customers.Remove(aCustomer);
            Db.SaveChanges();
            return 0;
        }

        public Customer GetByID(Customer customer)
        {
            Customer aCustomer = Db.customers.FirstOrDefault(c => c.ID == customer.ID);
            return aCustomer;
        }

        public List<Customer> search(Customer customer)
        {
            return Db.customers.Where(c => c.Name.ToLower().Contains(customer.Name.ToLower())).ToList();
        }
    }
}

