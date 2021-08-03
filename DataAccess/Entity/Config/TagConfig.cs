using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity.Config
{
    public class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasIndex(t => t.EnglishText).IsUnique();
            builder.HasIndex(t => t.PersianText).IsUnique();
            builder.HasIndex(t => new { t.EnglishText, t.PersianText }).IsUnique();

            builder.HasCheckConstraint($"CHK_{nameof(Tag.EnglishText)}_{nameof(Tag.PersianText)}",
                $"{nameof(Tag.EnglishText)} is not null or {nameof(Tag.PersianText)} is not null");
        }
    }
}
