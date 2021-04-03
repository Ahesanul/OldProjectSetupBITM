namespace OnlineShopWebApp.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Category
    {

        public int Id { get; set; }

        public int Code { get; set; }

       
        public string CategoryName { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
}
