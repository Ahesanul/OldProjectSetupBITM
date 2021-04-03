namespace OnlineShopWebApp.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Product
    {

        public int Id { get; set; }

        public int Code { get; set; }

    
        public string ProductName { get; set; }

        public int? ReOrderQuantity { get; set; }

        public string Description { get; set; }

        public int? CategoryID { get; set; }

        public byte[] Image { get; set; }

        public virtual Category Category { get; set; }


        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
