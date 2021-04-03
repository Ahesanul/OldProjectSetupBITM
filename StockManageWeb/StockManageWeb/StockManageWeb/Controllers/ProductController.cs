using AutoMapper;
using StockManage.BLL.BLL;
using StockManage.Models.Models;
using StockManageWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockManageWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        StockManageProductManager _stockManageManger = new StockManageProductManager();
        
        StockManageManager _stockManageManagerCategory = new StockManageManager();
        Product _product = new Product();
       // ProductVM _productvm = new ProductVM();
       

        public ActionResult Add()
        {
            ProductVM _productvm = new ProductVM();
            _productvm.CategoryList = _stockManageManagerCategory.Show()
               .Select(c => new SelectListItem()
               {
                   Value = c.ID.ToString(),
                   Text = c.Name
               }).ToList();



            _productvm.products = _stockManageManger.Show();
           
            return View(_productvm);
        }
        [Route("Add")]
        [HttpPost]
        public ActionResult Add(ProductVM model)
        {
            Product product = Mapper.Map<Product>(model);
            HttpPostedFileBase image = Request.Files["ImageData"];
            var name = _stockManageManger.Show();
            bool isvalid = true;
            foreach (var item in name)
            {
                if (model.Name == item.Name)
                {
                    isvalid = false;
                }
                
            }


            if (isvalid != false)
            {
                _stockManageManger.Add(product, image);
                ViewBag.message = "Inserted";
            }
            else
            {
                ViewBag.message = "Already Have";
            }

            //model.CategoryList = _stockManageManagerCategory.Show()
            //   .Select(c => new SelectListItem()
            //   {
            //       Value = c.ID.ToString(),
            //       Text = c.Name
            //   }).ToList();




            //model.products = _stockManageManger.Show();


            

            return RedirectToAction("add");
        }

        [HttpPost]
        public ActionResult Show(ProductVM model)
        {
            Product product = Mapper.Map<Product>(model);
           

            if (product.Name != null)
            {
                model.products = _stockManageManger.Search(product);

            }
            return View(model);
        }

        public ActionResult Show()
        {
            ProductVM _productvm = new ProductVM();
            _productvm.products = _stockManageManger.Show();

            return View(_productvm);
        }

        public ActionResult Edit(int? id)
        {
            ProductVM model = new ProductVM();
            model.ID = Convert.ToInt32(id);
            Product product = Mapper.Map<Product>(model);

            var GetByID = _stockManageManger.GetByID(product);

            model.Name = GetByID.Name;
            model.Code = GetByID.Code;
            model.Discription = GetByID.Discription;
            model.ReorderLevel = GetByID.ReorderLevel;
            model.Data = GetByID.Data;

            model.CategoryList = _stockManageManagerCategory.Show()
               .Select(c => new SelectListItem()
               {
                   Value = c.ID.ToString(),
                   Text = c.Name
               }).ToList();


            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ProductVM model)
        {

            Product aProduct = Mapper.Map<Product>(model);
            HttpPostedFileBase image = Request.Files["ImageData"];
            _stockManageManger.Edit(aProduct,image);
            ViewBag.message = "Edited";
            model.products = _stockManageManger.Show();

            return RedirectToAction("Add");
        }


        public ActionResult Delete(int? id)
        {
            ProductVM model = new ProductVM();
            Product aProduct = Mapper.Map<Product>(model);
            aProduct.ID = Convert.ToInt32(id);
            if (id != null)
            {
                var product = _stockManageManger.GetByID(aProduct);
                _stockManageManger.Delete(product);
            }




            model.products = _stockManageManger.Show();
            return RedirectToAction("Add");

        }

        //[HttpPost]
        //public JsonResult GetbyID2( int ID)
        //{
        //    ProductVM model = new ProductVM();
        //    Product aProduct = Mapper.Map<Product>(model);
        //    aProduct.ID = Convert.ToInt32(ID); ;
        //    var Product = _stockManageManger.GetByID(aProduct);
            
        //    model.Data = Product.Data;
        //    return Json(model, JsonRequestBehavior.AllowGet);
        //}

    }
}
