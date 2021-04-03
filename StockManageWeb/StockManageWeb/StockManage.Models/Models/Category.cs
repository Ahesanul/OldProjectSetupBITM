using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManage.Models.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Not null")]
        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Not null")]
        [StringLength(50, MinimumLength = 3)]
        public string Code { get; set; }

       
    }
}
