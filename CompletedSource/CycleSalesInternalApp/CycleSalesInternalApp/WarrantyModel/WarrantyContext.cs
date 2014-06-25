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
            options.UseAzureTableStorage(ConfigurationManager.ConnectionStrings["WarrantyConnection"].ConnectionString);
        }

        protected override void OnModelCreating(Microsoft.Data.Entity.Metadata.ModelBuilder builder)
        {
            builder.Entity<WarrantyInfo>()
                .Key(w => new { w.BikeModelNo, w.BikeSerialNo })
                .AzureTableProperties(p =>
                {
                    p.PartitionKey(w => w.BikeModelNo);
                    p.RowKey(w => w.BikeSerialNo);
                    p.Timestamp("Timestamp", shadowProperty: true);
                });
        }
    }
}
