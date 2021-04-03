using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StockManageWeb.Models
{
    public class SupplierVM
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Code { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 3)]
        public string Address { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Contact { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string ContactPerson { get; set; }
        [Required]
        public byte[] Data { get; set; }



        public List<Supplier> suppliers { get; set; }
    }
}