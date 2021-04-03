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
    public class StockController : Controller
    {
        StockManageDbContext Db = new StockManageDbContext();
        StockManager _manager= new StockManager();
       
        public ActionResult Index()
        {
            StockVM model = new StockVM();
            model.ProductList = _manager.ShowProduct().Select(c => new SelectListItem{Value = c.ID.ToString(),Text = c.Name}).ToList();
            
            model.Sales = _manager.sales();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(StockVM model)
        {
            if(model.Discription!=null)
            {
                OrderRemark orderRemark = new OrderRemark();

                orderRemark.PurchaseID = model.Purchase.ID;
                orderRemark.Date = model.Date;
                orderRemark.Discription = model.Discription;
                Db.orderRemarks.Add(orderRemark);
                Db.SaveChanges();
            }
            

            //model.Purchases = _manager.purchases();

            if (model.Reordercheck == null && model.Expirecheck == null)
            {
                model.Sales = (Db.sales.Where(c => c.Purchase.product.Name == model.productName).ToList()).Where(c => c.Purchase.Date >= model.sDate && c.Purchase.Date <= model.eDate).ToList();
                
            }
            else if (model.Reordercheck == "true" && model.Expirecheck == null)
            {
                model.Sales = ((Db.sales.Where(c => c.Purchase.product.Name == model.productName).ToList()).Where(c => c.Purchase.expireDate >= model.sDate && c.Purchase.expireDate <= model.eDate).ToList()).Where(c => c.quantity <= c.Purchase.product.ReorderLevel).ToList();

                

            }

            else if (model.Reordercheck == "true" && model.Expirecheck == "true")
            {
                model.Sales = ((Db.sales.Where(c => c.Purchase.product.Name == model.productName).ToList()).Where(c => c.Purchase.expireDate >= model.sDate && c.Purchase.expireDate <= model.eDate).ToList()).Where(c => c.quantity <= c.Purchase.product.ReorderLevel && c.Purchase.expireDate <= model.eDate).ToList();

                
            }

            else if (model.Reordercheck == null && model.Expirecheck == "true")
            {
                model.Sales = ((Db.sales.Where(c => c.Purchase.product.Name == model.productName).ToList()).Where(c => c.Purchase.expireDate >= model.sDate && c.Purchase.expireDate <= model.eDate).ToList()).Where(c => c.Purchase.expireDate <= model.eDate).ToList();
            }

            //model.stockoutBlance=model.Purchases.Where(c=>c.).
            return RedirectToAction("index");
        }
    }
}