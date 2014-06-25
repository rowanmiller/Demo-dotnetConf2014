namespace CycleSalesPublicSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        public int Customer_Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string email { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
