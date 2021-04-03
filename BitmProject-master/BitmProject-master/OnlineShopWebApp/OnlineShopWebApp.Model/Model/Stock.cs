namespace OnlineShopWebApp.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class Stock
    {
        public int ID { get; set; }

        public int? ProductID { get; set; }


        public DateTime? OrderDate { get; set; }


        public string InvoiceNo { get; set; }

        public int? SupplierID { get; set; }


        public DateTime? ManufacturedDate { get; set; }


        public DateTime? ExpireDate { get; set; }

        public int? Quantity { get; set; }

        public double? UnitPrice { get; set; }

        public string Remark { get; set; }

        public int? MRP { get; set; }

        public int? CustomerID { get; set; }

        public string Status { get; set; }

        public DateTime? SalesDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
