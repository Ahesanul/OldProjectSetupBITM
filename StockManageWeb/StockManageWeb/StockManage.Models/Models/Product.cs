using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManage.Models.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Code { get; set; }
        
        [Required]
        public int ReorderLevel { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Discription { get; set; }
        [Required]
        public byte[] Data { get; set; }

        [Required]
        public int CategoryID { get; set; }
        public virtual Category categories { get; set; }

        [NotMapped]
        public virtual List<Product> Products { get; set; }
    }
}
