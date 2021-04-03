using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManage.Models.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(20, MinimumLength = 5)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(150, MinimumLength = 5)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(20, MinimumLength = 5)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 5)]
        public string ContactPerson { get; set; }
        [Required]
        public byte[] Data { get; set; }
    }
       
}
