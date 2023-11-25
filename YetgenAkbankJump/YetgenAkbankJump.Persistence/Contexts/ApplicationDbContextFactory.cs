using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace YetgenAkbankJump.Persistence.Contexts
{
	public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
	{
		public ApplicationDbContext CreateDbContext(string[] args)
		{
			// appsettings.json dosyasının konumu
			string path = Path.Combine(Directory.GetCurrentDirectory(), "..", "YetgenAkbankJump.WebApi");

			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(path)
				.AddJsonFile("appsettings.json")
				.Build();


			var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

			var connectionString = configuration.GetSection("YetgenPostgreSQLDB").Value;

			optionsBuilder.UseNpgsql(connectionString);

			return new ApplicationDbContext(optionsBuilder.Options);
		}
	}
}