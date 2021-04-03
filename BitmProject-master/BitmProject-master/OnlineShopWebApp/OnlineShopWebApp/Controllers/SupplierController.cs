using OnlineShopWebApp.BLL.Manager;
using OnlineShopWebApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopWebApp.Controllers
{
    public class SupplierController : Controller
    {
        private SupplierManager _supplierManager = new SupplierManager();
        // GET: Category
        public ActionResult Index()
        {
            return View(_supplierManager.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ActionName("Create")]
        public ActionResult ConfirmCreate(Supplier supplier)
        {
            int executed = _supplierManager.Create(supplier);
            if (executed > 0)
            {
                return RedirectToAction("Index");
            }

            return View("Create");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_supplierManager.GetById(id));
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult ConfirmEdit(Supplier supplier)
        {
            int executed = _supplierManager.update(supplier);
            if (executed > 0)
            {
                return RedirectToAction("Index");
            }

            return View("Edit");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_supplierManager.GetById(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            int executed = _supplierManager.Delete(id);
            if (executed > 0)
            {
                return RedirectToAction("Index");
            }

            return View("Edit");
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_supplierManager.GetById(id));
        }
    }
}
