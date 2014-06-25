using CycleSalesInternalApp.CycleSalesModel;
using System.Collections.Generic;
using System.Linq;

namespace CycleSalesInternalApp.CycleSalesModel
{
    public class PriceService
    {
        private CycleSalesContext _context;

        public PriceService(CycleSalesContext context)
        {
            _context = context;
        }

        public IEnumerable<ConversionResult> CalculateForeignPrices(decimal exchangeRate)
        {
            var query = from b in _context.Bikes
                        orderby b.Bike_Id
                        select new ConversionResult 
                        { 
                            BikeName = b.Name, 
                            USPrice = b.Retail, 
                            ForeignPrice = b.Retail * exchangeRate 
                        };

            return query.ToList();
        }

        public class ConversionResult
        {
            public string BikeName { get; set; }
            public decimal USPrice { get; set; }
            public decimal ForeignPrice { get; set; }
        }
    }
}
