using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.Domain.Identity;


namespace YetgenAkbankJump.Persistence.Contexts
{
	public class YetgenIdentityContext:IdentityDbContext<User,Role,Guid>
	{
		public YetgenIdentityContext(DbContextOptions<YetgenIdentityContext> dbContextOptions) : base(dbContextOptions)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly
				.GetExecutingAssembly());

			modelBuilder.Ignore<Student>();
			modelBuilder.Ignore<Product>();
			modelBuilder.Ignore<Category>();	

			base.OnModelCreating(modelBuilder);
		}
	}
}
