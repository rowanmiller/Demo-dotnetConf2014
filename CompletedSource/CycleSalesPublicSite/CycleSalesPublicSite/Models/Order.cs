namespace CycleSalesPublicSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public Order()
        {
            OrderLines = new List<OrderLine>();
        }

        public int Order_Id { get; set; }

        public DateTime Placed { get; set; }

        public decimal NetTotal { get; set; }

        public decimal SalesTax { get; set; }

        public int Customer_Id { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual List<OrderLine> OrderLines { get; set; }
    }
}
