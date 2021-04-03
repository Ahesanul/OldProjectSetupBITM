using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManage.Models.Models
{
    public class Purchase
    {
        public int ID { get; set; }

        
        public int SupplierID { get; set; }
        public Supplier supplier { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string invoiceNo{ get; set; }

        [Required]
        public int ProductID { get; set; }
        public virtual Product product { get; set; }
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
        public int totalPrice { get; set; }
        [Required]
        public int newMRP { get; set; }

        

    }
}
