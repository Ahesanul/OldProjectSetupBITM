using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockManageWeb.Models
{
    public class ProductVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Code { get; set; }

        [Required]
        [DisplayName("Category")]
        public int CategoryID { get; set; }

        [Required]
        public int ReorderLevel { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Discription { get; set; }
        [Required]
        public byte[] Data { get; set; }


        public IEnumerable<SelectListItem> CategoryList { get; set; }
        
        public List<Product> products { get; set; }
    }
}