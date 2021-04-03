namespace OnlineShopWebApp.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Customer
    {


        public int ID { get; set; }

        public int? Code { get; set; }

       
        public string Name { get; set; }

        
        public string Address { get; set; }

     
        public string Email { get; set; }

   
        public string Contact { get; set; }

        public int? Point { get; set; }

        public byte[] Image { get; set; }

       
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
