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
    public class StockManageSupplierManager
    {
        Supplier supplier= new Supplier();
        StockManageSupplierRipository _Repository = new StockManageSupplierRipository();
        public void Add(Supplier supplier, HttpPostedFileBase image)
        {
            _Repository.add(supplier,image);
        }
        public List<Supplier> Show()
        {
            return _Repository.Show();
        }

        public void Edit(Supplier supplier)
        {
            _Repository.Edit(supplier);
        }

        public void Delete(Supplier supplier)
        {
            _Repository.Delete(supplier);
        }

        public Supplier GetByID(Supplier supplier)
        {
            return _Repository.GetByID(supplier);
        }
    }
}
