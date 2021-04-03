using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace StockManageWeb.Models
{
    public class StockVM
    {
        public virtual Purchase  Purchase { get; set; }

        public virtual List<Sale> Sales { get; set; }
        public string productName { get; set; }
        public string category { get; set; }
        [DataType(DataType.Date)]
        public DateTime sDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime eDate { get; set; }
        public string Reordercheck { get; set; }
        public string Expirecheck{ get; set; }
        public int stockexpireQ { get; set; }
        public int stockopningBlance { get; set; }
        public int stockinBlance { get; set; }
        public int stockoutBlance { get; set; }
        public int stockclsoeBlance { get; set; }
        public IEnumerable<SelectListItem> ProductList { get; set; }
        public string Discription { get; set; }
        public int PurchaseID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}