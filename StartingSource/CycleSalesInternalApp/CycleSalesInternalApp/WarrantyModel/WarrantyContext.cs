using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System.Configuration;

namespace CycleSalesInternalApp.WarrantyModel
{
    class WarrantyContext : DbContext
    {
        private static readonly string _connection = ConfigurationManager.ConnectionStrings["WarrantyConnection"].ConnectionString;

        public DbSet<WarrantyInfo> Warranties { get; set; }
    }
}
