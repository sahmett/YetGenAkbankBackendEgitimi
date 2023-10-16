using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productify.Domain.Entitities;

namespace Productfy.Percistence.Context
{
	public class ProductifyDbContext : DbContext
	{
		//Dbset bir liste IList den kalıtım alıyor böylece LINQ kullanılabilir. Public olmalı
		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("ProductfyDb");
		}
	}
}
