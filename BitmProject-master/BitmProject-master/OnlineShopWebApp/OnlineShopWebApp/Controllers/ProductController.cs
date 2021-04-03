using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopWebApp.Model.Model;
using OnlineShopWebApp.BLL.Manager;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        private ProductManager _productManager = new ProductManager();
        // GET: Category
        public ActionResult Index()
        {
            return View(_productManager.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ActionName("Create")]
        public ActionResult ConfirmCreate(Product product)
        {
            int executed = _productManager.Create(product);
            if (executed > 0)
            {
                return RedirectToAction("Index");
            }

            return View("Create");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_productManager.GetById(id));
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult ConfirmEdit(Product product)
        {
            int executed = _productManager.update(product);
            if (executed > 0)
            {
                return RedirectToAction("Index");
            }

            return View("Edit");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_productManager.GetById(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            int executed = _productManager.Delete(id);
            if (executed > 0)
            {
                return RedirectToAction("Index");
            }

            return View("Edit");
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_productManager.GetById(id));
        }
    }
}
