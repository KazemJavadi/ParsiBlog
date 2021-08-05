using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Entity.Config
{
    class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasIndex(c => c.PersianName).IsUnique();
            builder.HasIndex(c => c.EnglishName).IsUnique();
            builder.HasIndex(c => new { c.PersianName, c.EnglishName }).IsUnique();

            builder.HasCheckConstraint($"CHK_{nameof(Category.PersianName)}_{nameof(Category.EnglishName)}",
                $"{nameof(Category.PersianName)} is not null or {nameof(Category.EnglishName)} is not null");
        }
    }
}
