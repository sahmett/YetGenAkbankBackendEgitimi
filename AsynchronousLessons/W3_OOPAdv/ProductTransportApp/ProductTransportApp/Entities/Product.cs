using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTransportApp.Entities
{
    internal class Product
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public Product(string title, decimal weight, decimal price) : this()
        {   
            Title = title;
            Weight = weight;
            Price = price;
        }
        public Product()
        {
             Id = Guid.NewGuid();
        }
    }
}
