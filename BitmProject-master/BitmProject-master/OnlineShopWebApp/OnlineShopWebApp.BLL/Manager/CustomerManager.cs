using OnlineShopWebApp.DAL.Repository;
using OnlineShopWebApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopWebApp.BLL.Manager
{
    public class CustomerManager
    {

        private CustomerRepository db = new CustomerRepository();
        public List<Customer> GetAll()
        {
            return db.GetAll();
        }

        public Customer GetById(int id)
        {
            return db.GetById(id);
        }

        public int Create(Customer customer)
        {
            return db.Create(customer);
        }

        public int update(Customer customer)
        {
            return db.update(customer);
        }

        public int Delete(int id)
        {
            return db.Delete(id);
        }

    }
}
