using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StockManageWeb.Models
{
    public class CategoryVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Code { get; set; }

        public List<Category> categories { get; set; }
    }
}