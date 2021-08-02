using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity.Config
{
    public class LanguageConfig : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasIndex(l => l.Code).IsUnique();
            builder.Property(l => l.Code).IsRequired(true);

            builder.HasIndex(l => l.LocalName).IsUnique();
            builder.Property(l => l.LocalName).IsRequired(true);

            builder.Property(l => l.SecondLanguageName).IsRequired(false);
            builder.HasIndex(l => l.SecondLanguageName).IsUnique();
        }
    }
}
