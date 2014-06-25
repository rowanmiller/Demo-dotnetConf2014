namespace CycleSalesPublicSite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CycleContext : DbContext
    {
        public CycleContext()
            : base("name=CycleContext3")
        {
        }

        public virtual DbSet<Bike> Bikes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.AddFromAssembly(this.GetType().Assembly);
            modelBuilder.Entity<Bike>()
                .Property(e => e.ModelNo)
                .IsUnicode(false);
        }
    }
}
