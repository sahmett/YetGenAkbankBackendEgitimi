﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetgenAkbankJump.Persistence.Contexts
{
	internal class YetgenIdentityContextFactory : IDesignTimeDbContextFactory<YetgenIdentityContext>
	{
		public YetgenIdentityContext CreateDbContext(string[] args)
		{
			// appsettings.json dosyasının konumu
			string path = Path.Combine(Directory.GetCurrentDirectory(), "..", "YetgenAkbankJump.WebApi");

			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(path)
				.AddJsonFile("appsettings.json")
				.Build();


			var optionsBuilder = new DbContextOptionsBuilder<YetgenIdentityContext>();

			var connectionString = configuration.GetSection("YetgenPostgreSQLDB").Value;

			optionsBuilder.UseNpgsql(connectionString);

			return new YetgenIdentityContext(optionsBuilder.Options);
		}
	}
}
