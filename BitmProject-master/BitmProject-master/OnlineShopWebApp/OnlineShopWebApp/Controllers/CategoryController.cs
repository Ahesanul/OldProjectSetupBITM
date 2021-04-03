using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopWebApp.BLL.Manager;
using OnlineShopWebApp.Model.Model;

namespace OnlineShopWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager _categoryManager = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            return View(_categoryManager.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ActionName("Create")]
        public ActionResult ConfirmCreate(Category category)
        {
           int executed =  _categoryManager.Create(category);
           if (executed > 0)
           {
               return RedirectToAction("Index");
           }

           return View("Create");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_categoryManager.GetById(id));
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult ConfirmEdit(Category category)
        {
            int executed = _categoryManager.update(category);
            if (executed > 0)
            {
                return RedirectToAction("Index");
            }

            return View("Edit");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_categoryManager.GetById(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            int executed = _categoryManager.Delete(id);
            if (executed > 0)
            {
                return RedirectToAction("Index");
            }

            return View("Edit");
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_categoryManager.GetById(id));
        }
    }
}