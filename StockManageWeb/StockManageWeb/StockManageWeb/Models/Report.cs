using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockManageWeb.Models
{
    public class Report
    {
        public virtual List<Sale> Sales { get; set; }
        public IEnumerable<SelectListItem> ProductList { get; set; }

        [DataType(DataType.Date)]
        public DateTime sDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime eDate { get; set; }
    }
}