using OnlineShopWebApp.MyContext;
using OnlineShopWebApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopWebApp.DAL.Repository
{
    public class CustomerRepository
    {
        private OnlineShopManagementContext db = new OnlineShopManagementContext();
        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            Customer customer = new Customer();
            customer = db.Customers.SingleOrDefault(x => x.ID == id);

            /*
            var x = from c in db.Categories
                where c.Id == id
                select c;
            */
            return customer;
        }

        public int Create(Customer customer)
        {
            db.Customers.Add(customer);
            int executed = db.SaveChanges();
            return executed;
        }

        public int update(Customer customer)
        {
            Customer upcustomer = this.GetById(customer.ID);
            upcustomer.Name = customer.Name;
            upcustomer.Address = customer.Address;
            upcustomer.Code = customer.Code;
            upcustomer.Contact = customer.Contact;
            upcustomer.Email = customer.Email;
            upcustomer.Point = customer.Point;
            upcustomer.Image = customer.Image;
           
            int executed = db.SaveChanges();
            return executed;
        }

        public int Delete(int id)
        {
            Customer customer = new Customer();
            customer = db.Customers.SingleOrDefault(x => x.ID == id);
            db.Customers.Remove(customer);
            int executed = db.SaveChanges();

            return executed;
        }

    }
}
