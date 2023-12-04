using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YetgenAkbankJump.Domain.Entities;

namespace YetgenAkbankJump.Persistence.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			// ID 
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();

			// Name
			builder.Property(x => x.Name).IsRequired();
			builder.Property(x => x.Name).HasMaxLength(75);

		// Common Fields

			// CreatedByUserId
			builder.Property(x => x.CreatedByUserId).IsRequired();
			builder.Property(x => x.CreatedByUserId).HasMaxLength(75);

			// CreatedOn
			builder.Property(x => x.CreatedOn).IsRequired();

			// ModifiedByUserId
			builder.Property(x => x.ModifiedByUserId).IsRequired(false);
			builder.Property(x => x.ModifiedByUserId).HasMaxLength(75);

			// LastModifiedOn
			builder.Property(x => x.LastModifiedOn).IsRequired(false);

			// DeletedByUserId
			builder.Property(x => x.DeletedByUserId).IsRequired(false);
			builder.Property(x => x.DeletedByUserId).HasMaxLength(75);

			// DeletedOn
			builder.Property(x => x.DeletedOn).IsRequired(false);

			// IsDeleted
			builder.Property(x => x.IsDeleted).IsRequired();

			//	Relationships
			//Ör-> Categoryden >> bu kategorinin çok productu var, productun 1 kategorisi var
			//Ör-> Producttan  >> bu productun bir kategorisi var, kategorinin çok productu var

			builder.HasMany(x => x.Products)
				.WithOne(x => x.Category)
				.HasForeignKey(x => x.CategoryId);

			// Category ID

			// Category 

			builder.ToTable("Categories");
		}

	}

}
