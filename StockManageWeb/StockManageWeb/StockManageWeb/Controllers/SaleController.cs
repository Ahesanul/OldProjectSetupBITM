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
    public class SaleController : Controller
    {
        StockManageSaleManager _stockManageManger = new StockManageSaleManager();
        PurchaseManager _perchaseManager = new PurchaseManager();
        Sale _supplier = new Sale();
        Customer _Customer = new Customer();
        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {

            var model = new SalesVm();
            model.CustomerList = _stockManageManger.Show()
                                                    .Select(c => new SelectListItem
                                                    {
                                                        Value = c.ID.ToString(),
                                                        Text = c.Name
                                                    })
                                                    .ToList();


            var List = _stockManageManger.ShowProduct()
                                                    .Select(c => new SelectListItem
                                                    {
                                                        Value = c.ID.ToString(),
                                                        Text = c.product.Name
                                                    }).ToList();

            model.ProductList = List.ToList().Distinct();
            
            return View(model);

        }

        [HttpPost]
        public ActionResult Add(SalesVm model)
        {
            var listquantity = _perchaseManager.totalPrice();
            var purchaselist= new List<Purchase>();
            var sales = new List<Sale>();
            var customerID = model.CustomerID;
             




            foreach (var item in model.sales)
            {
                item.CustomerID = customerID;
                item.PurchaseID = item.PurchaseID;
                item.date = model.date;

                sales.Add(item);
            }

            if (ModelState.IsValid)
            {

                //var sale = Mapper.Map<Sale>(model);

               


                bool isAdded = _stockManageManger.Add(sales);

                if (isAdded)
                {
                    foreach (var item in sales )
                    {
                        int q = 0;
                        foreach (var i in listquantity)
                        {

                            if (i.ID == item.PurchaseID)
                            {

                                i.quantity -= item.quantity;
                                purchaselist.Add(i);
                            }

                        }
                        
                    }

                    _perchaseManager.update(purchaselist);
                    return RedirectToAction("Add");
                }

            }



            



            return RedirectToAction("Add");

        }

      

        [HttpPost]
        public ActionResult Index(Sale sale)
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetbyID( int customerID)
        {
            

            
            var aCustomer = _stockManageManger.GetByID(customerID);

            return Json(aCustomer, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetbyIDReorder(int productID)
        {



            var aCustomer = _stockManageManger.GetByID(productID);

            return Json(aCustomer, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetbyID2(int productID)
        {
            
            var aProduct = _stockManageManger.GetByID2(productID);

            return Json(aProduct, JsonRequestBehavior.AllowGet);
        }
    }
}