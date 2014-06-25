namespace CycleSalesPublicSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bike
    {
        public Bike()
        {
            OrderLines = new List<OrderLine>();
            Promotions = new List<Promotion>();
        }

        public int Bike_Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ModelNo { get; set; }

        public decimal Retail { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual List<OrderLine> OrderLines { get; set; }

        public virtual List<Promotion> Promotions { get; set; }
    }
}
