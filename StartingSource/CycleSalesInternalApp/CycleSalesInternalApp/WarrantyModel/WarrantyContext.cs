using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System.Configuration;

namespace CycleSalesInternalApp.WarrantyModel
{
    class WarrantyContext : DbContext
    {
        public DbSet<WarrantyInfo> Warranties { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            var connection = ConfigurationManager.ConnectionStrings["WarrantyConnection"].ConnectionString;

        }
    }
}
