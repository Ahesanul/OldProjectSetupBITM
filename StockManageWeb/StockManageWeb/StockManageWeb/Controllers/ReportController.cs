using StockManage.BLL.BLL;
using StockManage.DatabaseContext.DatabaseContext;
using StockManageWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockManageWeb.Controllers
{
    public class ReportController : Controller
    {
        StockManageDbContext Db = new StockManageDbContext();
        StockManager _manager = new StockManager();
        public ActionResult Index()
        {
            Report model = new Report();
            model.ProductList = _manager.ShowProduct().Select(c => new SelectListItem { Value = c.ID.ToString(), Text = c.Name }).ToList();

            model.Sales = _manager.sales();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(Report model)
        {
             
            
            model.Sales = Db.sales.Where(c => c.Purchase.Date >= model.sDate && c.Purchase.Date <= model.eDate).ToList();

            return View(model);
        }
    }
}