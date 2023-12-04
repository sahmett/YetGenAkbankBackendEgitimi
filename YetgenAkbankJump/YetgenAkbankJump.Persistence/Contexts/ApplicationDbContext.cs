﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YetgenAkbankJump.Domain.Entities;

namespace YetgenAkbankJump.Persistence.Contexts
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }

			
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions):base(dbContextOptions)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly
				.GetExecutingAssembly());

			base.OnModelCreating(modelBuilder);
		}
	}
}
