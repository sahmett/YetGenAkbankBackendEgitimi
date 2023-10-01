using ProductTransportApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTransportApp.Services
{
    internal class ShippingService
    {
        public decimal CalculateTax(Product product, string country)
        {
            decimal taxRate = 1.0m * product.Price; // Varsayılan vergi oranı

            if (country == "Turkey")
            {
                taxRate = 1.1m * product.Price;
            }
            else if (country == "Spain")
            {
                taxRate = 1.4m * product.Price;
            }
            else if (country == "Hungary")
            {
                taxRate = 1.2m * product.Price;
            }

            return taxRate;
        }

        public decimal CalculateTax(Product product, CountryInformation countryInfo)
        {
            return product.Price * countryInfo.TaxRate;
        }
    }
}
