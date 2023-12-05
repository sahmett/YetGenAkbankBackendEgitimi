using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetgenAkbankJump.Domain.Entities
{
	public class Category : EntityBase<Guid>
	{
        public string Name { get; set; }
		//public ICollection<Product> Products { get; set; } //ilk kullanım one to many

		public ICollection<ProductCategory> ProductCategories { get; set; } //ikinci kullanım one to many


	}
}
