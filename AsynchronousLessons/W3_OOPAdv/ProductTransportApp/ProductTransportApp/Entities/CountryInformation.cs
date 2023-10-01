using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTransportApp.Entities
{
    internal class CountryInformation
    {   
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
        public CountryInformation() { }

        public CountryInformation(string name, decimal taxRate)
        {
            Id = new Guid();
            Name = name;
            TaxRate = taxRate;
        }
        public CountryInformation(string[] lineData)
        {
            Id = new Guid();
            Name = lineData[0];
            TaxRate = Convert.ToDecimal(lineData[1]);
        }

    }
}
