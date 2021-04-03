using AutoMapper;
using StockManage.BLL.BLL;
using StockManage.DatabaseContext.DatabaseContext;
using StockManage.Models.Models;
using StockManageWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockManageWeb.Controllers
{
    public class SupplierController : Controller
    {
        StockManageSupplierManager _stockManageManger = new StockManageSupplierManager();
        StockManageDbContext Db = new StockManageDbContext();
        Supplier _supplier= new Supplier();

        public ActionResult Add()
        {
            SupplierVM model = new SupplierVM();
            model.suppliers = _stockManageManger.Show();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(SupplierVM model)
        {
            Supplier supplier = Mapper.Map<Supplier>(model);
            HttpPostedFileBase image = Request.Files["ImageData"];
           
                _stockManageManger.Add(supplier,image);
                ViewBag.message = "Inserted";
           
            model.suppliers = _stockManageManger.Show();

            return View(model);
        }

        [HttpPost]
        public ActionResult Show(SupplierVM model)
        {
            
            Supplier supplier = Mapper.Map<Supplier>(model);
            model.suppliers = _stockManageManger.Show();
            if (supplier.Name != null)
            {
                model.suppliers = Db.suppliers.Where(c => c.Name.ToLower().Contains(supplier.Name.ToLower())).ToList();
            }


            return View(model);
        }

        public ActionResult Show()
        {
            SupplierVM model = new SupplierVM();

            model.suppliers = _stockManageManger.Show();

            return View(model);
        }

        //public ActionResult Edit(int? id)
        //{
        //    _supplier.ID = Convert.ToInt32(id);

        //    _supplier.suppliers = _stockManageManger.Show();
        //    var supplier = _stockManageManger.GetByID(_supplier);
        //    ViewBag.message = "Inserted";
        //    return View(supplier);
        //}

        //[HttpPost]
        //public ActionResult Edit(Supplier supplier)
        //{


        //    _supplier.Name = supplier.Name;
        //    _supplier.ID = supplier.ID;
        //    _supplier.Code = supplier.Code;
        //    _supplier.Address = supplier.Address;
        //    _supplier.Email = supplier.Email;
        //    _supplier.Contact = supplier.Contact;
        //    _supplier.ContactPerson = supplier.ContactPerson;
        //    _stockManageManger.Edit(_supplier);


        //    _supplier.suppliers = _stockManageManger.Show();

        //    return View(_supplier);
        //}


        //public ActionResult Delete(int? id)
        //{
        //    SupplierVM model = new SupplierVM();
        //    Supplier supplier = Mapper.Map<Supplier>(model);
        //    _supplier.ID = Convert.ToInt32(id);
        //    if (id != null)
        //    {
        //        var supplier = _stockManageManger.GetByID(_supplier);
        //        _stockManageManger.Delete(supplier);
        //    }




        //    _supplier.suppliers = _stockManageManger.Show();
        //    return View(_supplier);

        //}

    }
}