using StockManage.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Web;

namespace StockManageWeb.Models
{
    public class CustomerVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(150, MinimumLength = 5)]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public int Loyalty { get; set; }


        public byte[] Data { get; set; }


        public List<Customer> customers { get; set; }
    }
}