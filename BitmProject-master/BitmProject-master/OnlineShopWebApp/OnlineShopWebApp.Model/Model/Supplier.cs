namespace OnlineShopWebApp.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class Supplier
    {


        public int ID { get; set; }

        public int? Code { get; set; }

        public string Name { get; set; }


        public string Address { get; set; }

 
        public string Email { get; set; }


        public string Contact { get; set; }

        public string ContactPerson { get; set; }

        public byte[] Logo { get; set; }


        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
