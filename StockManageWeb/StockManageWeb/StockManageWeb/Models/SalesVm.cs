using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockManageWeb.Models
{
    public class SalesVm
    {
        public int ID { get; set; }

        [Display(Name ="Customer")]
        public int CustomerID { get; set; }
        public Customer Customers { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [Display(Name = "Product")]
        public int PurchaseID { get; set; }
        public virtual Purchase Purchase { get; set; }
        public int grandTotal { get; set; }
        public int quantity { get; set; }
        public int MRP { get; set; }
        public int TotalMRP { get; set; }

        public List<Sale> sales { get; set; }
        public List<Purchase> Purchaselist { get; set; }
        public IEnumerable<SelectListItem> CustomerList { get; set; }
        public IEnumerable<SelectListItem> ProductList { get; set; }
    }
}