using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity.Config
{
    class CategoryTranslationConfig : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.HasIndex(ct => new { ct.CategoryId, ct.LanguageId }).IsUnique();

            builder.HasIndex(ct => ct.CategoryId);

            builder.Property(ct => ct.Text).IsRequired(true);

            builder.Property(ct => ct.OrderValue).IsRequired(false);
        }
    }
}
