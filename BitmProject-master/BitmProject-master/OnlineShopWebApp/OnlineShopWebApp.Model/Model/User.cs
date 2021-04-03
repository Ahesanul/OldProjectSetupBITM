namespace OnlineShopWebApp.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class User
    {
        public int Id { get; set; }

 
        public string UserName { get; set; }


        public string Password { get; set; }
    }
}
