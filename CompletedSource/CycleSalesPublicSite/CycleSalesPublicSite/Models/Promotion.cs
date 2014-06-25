namespace CycleSalesPublicSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Promotion
    {
        public int Promotion_Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal SalePrice { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        public int Bike_Id { get; set; }

        public virtual Bike Bike { get; set; }
    }
}
