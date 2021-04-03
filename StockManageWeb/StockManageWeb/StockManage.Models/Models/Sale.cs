using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManage.Models.Models
{
    public class Sale
    {
        public int ID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public Customer Customers { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        [Required]
        public int PurchaseID { get; set; }
        public virtual Purchase Purchase { get; set; }
        [Required]
        public int quantity { get; set; }
        public int MRP { get; set; }
        public int TotalMRP { get; set; }
    }
}
