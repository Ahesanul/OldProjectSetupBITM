using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManage.Models.Models
{
    public class OrderRemark
    {
        public int ID { get; set; }
        public  int PurchaseID { get; set; }
        public virtual Purchase Purchase{ get; set; }
        [DataType(DataType.Date)]
        public DateTime Date{ get; set; }
        public string Discription { get; set; }
    }
}
