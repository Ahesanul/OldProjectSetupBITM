using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockManage.Models.Models;
using StockManageWeb.Models;
using StockManage.BLL.BLL;
using AutoMapper;

namespace StockManageWeb.Controllers
{
    public class CategoryController : Controller
    {
        StockManageManager _stockManageManger = new StockManageManager();
        Category _category = new Category();
        CategoryVM _categoryvm = new CategoryVM();
       
        public ActionResult Add()
        {
           _categoryvm.categories = _stockManageManger.Show();

            return View(_categoryvm);
        }

        [HttpPost]
        public ActionResult Add(Category category)
        {
            if (ModelState.IsValid)

            {
                bool isvalid = true;
                if (category.Name != null && category.Code != null)
                {
                    foreach (var item in _stockManageManger.Show())
                    {
                        if (item.Name==category.Name)
                        {
                            isvalid = false;
                        }
                    }
                   if(isvalid!=false)
                    {
                        _stockManageManger.Add(category);
                        ViewBag.message = "Inserted";
                        ViewBag.color = "alert alert-info";
                    }
                    else
                    {
                        ViewBag.message = "Already Have";
                        ViewBag.color = "alert alert-danger";
                    }

                }
            }

            else
            {
                ViewBag.message = "Not Inserted";
                ViewBag.color = "alert alert-danger";
            }

            _categoryvm.categories = _stockManageManger.Show();

            return View(_categoryvm);
        }


        public ActionResult Show()
        {

            _categoryvm.categories = _stockManageManger.Show();

            return View(_categoryvm);
        }


        [HttpPost]
        public ActionResult Show(CategoryVM category)
        {
            _categoryvm.categories = _stockManageManger.Show();
            if (category.Name != null)
            {
                _categoryvm.categories = _categoryvm.categories.Where(c => c.Name.ToLower().Contains(category.Name.ToLower())).ToList();
            }


            return View(_categoryvm);
        }

        public ActionResult Edit(int? id)
        {
            CategoryVM model = new CategoryVM();
            model.ID = Convert.ToInt32(id);
            Category category = Mapper.Map<Category>(model);
            var GetByID = _stockManageManger.GetByID(category);
            model.Code= GetByID.Code;
            model.Name = GetByID.Name;

            
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CategoryVM model)
        {
            Category category = Mapper.Map<Category>(model);
          
            _category.Name = category.Name;
            _category.ID = category.ID;
            _category.Code = category.Code;
            _stockManageManger.Edit(_category);
            
            _categoryvm.categories = _stockManageManger.Show();
            ViewBag.message = "Updated";
            model = Mapper.Map<CategoryVM>(category);
            return View(model);
        }


        public ActionResult Delete(int? id)
        {
            CategoryVM model = new CategoryVM();
            
            
            if (id != null)
            {
                model.ID = Convert.ToInt32(id);
                Category category = Mapper.Map<Category>(model);
                
                _stockManageManger.Delete(category);
            }

            ViewBag.info = "Delete";
            _categoryvm.categories = _stockManageManger.Show();
            return View(_categoryvm);

        }




    }
}