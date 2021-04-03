using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockManageWeb.Models
{
    public class PurchaseVM
    {
        public int ID { get; set; }

        [Required]
        public int SupplierID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string invoiceNo { get; set; }

        [Required]
        public int ProductID { get; set; }
        [DataType(DataType.Date)]
        public DateTime manufactureDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime expireDate { get; set; }
        [Required]
        public string remarks { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public int unitPrice { get; set; }
        [Required]
        public int totalPrice { get; set; }

        public string aProduct_ReorderLevel { get; set; }

        public string aProduct_unitPrice { get; set; }
        public string aProduct_totalPrice { get; set; }

        public int stockexpireQ { get; set; }
        public int stockopningBlance { get; set; }
        public int stockinBlance { get; set; }
        public int stockoutBlance { get; set; }
        public int stockclsoeBlance { get; set; }

        [Required]
        public int newMRP { get; set; }

        public IEnumerable<SelectListItem> SupplierList { get; set; }
        public IEnumerable<SelectListItem> ProductList { get; set; }
        public List<Purchase> purchases { get; set; }
        public List<OrderRemark> orderRemarks { get; set; }
        public int ProductID2 { get; set; }
    }
}