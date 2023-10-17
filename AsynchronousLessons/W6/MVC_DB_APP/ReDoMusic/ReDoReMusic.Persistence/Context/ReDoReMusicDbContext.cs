using Microsoft.EntityFrameworkCore;
using ReDoReMusic.Domain.Entities;
using System.Diagnostics.Metrics;


namespace ReDoReMusic.Persistence.Context
{
	public class ReDoReMusicDbContext : DbContext
	{
		public DbSet<Domain.Entities.Instrument> InstrumentsDb {  get; set; }
		public DbSet<Brand> Brands { get; set; }

		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(Configuration.GetString("ConnectionString:PostgreSQL"));
		}

	} 
}
