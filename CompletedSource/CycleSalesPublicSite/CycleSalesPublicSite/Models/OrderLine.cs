namespace CycleSalesPublicSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderLine
    {
        public int OrderLine_Id { get; set; }

        public int Quantity { get; set; }

        public int SalePrice { get; set; }

        public int BikeSize { get; set; }

        public int Bike_Id { get; set; }

        public int Order_Id { get; set; }

        public virtual Bike Bike { get; set; }

        public virtual Order Order { get; set; }
    }
}
