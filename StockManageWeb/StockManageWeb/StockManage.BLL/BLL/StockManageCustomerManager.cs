using StockManage.Models.Models;
using StockManageWeb.repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StockManage.BLL.BLL
{
    public class StockManageCustomerManager
    {
        Customer customer= new Customer();
        StockManageCustomerRipository _Repository = new StockManageCustomerRipository();
        public void Add(Customer customer, HttpPostedFileBase image)
        {
            _Repository.add(customer, image);
        }
        public List<Customer> Show()
        {
            return _Repository.Show();
        }

        public void Edit(Customer customer)
        {
            _Repository.Edit(customer);
        }

        public void Delete(Customer customer)
        {
            _Repository.Delete(customer);
        }

        public Customer GetByID( Customer customer)
        {
            return _Repository.GetByID(customer);
        }

        public List<Customer> search(Customer customer)
        {
            return _Repository.search(customer);
        }

    }
}
