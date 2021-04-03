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
    public class PurchaseController : Controller
    {
        bool add = false;
        PurchaseManager _stockManageManger = new PurchaseManager();
        public ActionResult Add()
        {
            PurchaseVM model = new PurchaseVM();
           
            
            model.ProductList = _stockManageManger.ShowProduct()
                                                    .Select(c => new SelectListItem
                                                    {
                                                        Value = c.ID.ToString(),
                                                        Text = c.Name
                                                    })
                                                    .ToList();


            model.SupplierList = _stockManageManger.ShowSupplier()
                                                    .Select(c => new SelectListItem
                                                    {
                                                        Value = c.ID.ToString(),
                                                        Text = c.Name
                                                    })
                                                    .ToList();
            if(add==true)
            {
                ViewBag.mess = "Add Purchase Success";
            }
            else
            {
                ViewBag.mess = "Add Some Data";
            }

            
            
            model.orderRemarks=_stockManageManger.orderRemark();
            return View(model);

        }


        [HttpPost]
        public ActionResult Add(PurchaseVM model)
        {
            var listquantity = _stockManageManger.totalPrice();
           
            var purchases = new List<Purchase>();
            if (model.purchases!=null)
            {
                
                

                    var SupplierID = model.SupplierID;
                    var Date = model.Date;
                    var Invoice = model.invoiceNo;

                    foreach (var item in model.purchases)
                    {
                    int q = 0;
                        foreach (var i in listquantity)
                        {
                        
                            if (item.ProductID == i.ProductID && item.SupplierID == i.SupplierID)
                            {
                               
                                item.quantity += i.quantity;
                            }
                            else if (item.ProductID == i.ProductID && item.SupplierID != i.SupplierID)
                            {
                               
                                q = i.quantity;
                             }

                            
                        }
                        item.quantity += q;
                        item.SupplierID = SupplierID;
                        item.invoiceNo = Invoice;
                        item.Date = model.Date;
                        purchases.Add(item);
                    }
                    add = false;
               
                
            }
           else
            {
                add = false;
                
            }
            if (purchases != null)
            {
                    _stockManageManger.add(purchases);

            }
           
            

            return RedirectToAction("add");

        }


        public JsonResult GetbyID2(int productID)
        {
            //PurchaseVM model = new PurchaseVM();

            //model.aProduct_totalPrice = _stockManageManger.GetByIDtotalPrice(productID).ToString();
            //model.aProduct_ReorderLevel = _stockManageManger.GetByIDReorderLevel(productID).ToString();
            //model.aProduct_unitPrice = _stockManageManger.GetByIDunitPrice(productID).ToString(); 

            ////model.aProduct = aProduct;

            ////var aProduct = _stockManageManger.GetByIDReorderLevel(productID);

            PurchaseVM model = new PurchaseVM();
            string totalPrice = "", ReorderLevel = "", unitPrice = "";

            var a = _stockManageManger.GetByIDtotalPrice(productID);
            foreach (var item in a)
            {
                if (item.ProductID == productID)
                {
                    totalPrice = item.newMRP.ToString();
                    unitPrice = item.unitPrice.ToString();
                    ReorderLevel = item.product.Code.ToString();
                }

            }


            model.aProduct_totalPrice = totalPrice;
            model.aProduct_ReorderLevel = ReorderLevel;
            model.aProduct_unitPrice = unitPrice;



            return Json(model, JsonRequestBehavior.AllowGet);
        }


    }
}