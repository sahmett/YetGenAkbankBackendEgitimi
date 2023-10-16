using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productify.Domain.Entitities
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public DateTime CreatedDate { get; set; }
		public Product(string name)
		{
			Id = Guid.NewGuid();
			Name = name;
			CreatedDate = DateTime.Now;
		}
	}
}
