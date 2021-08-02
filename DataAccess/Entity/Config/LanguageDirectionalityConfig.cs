using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity.Config
{
    class LanguageDirectionalityConfig : IEntityTypeConfiguration<LanguageDirectionality>
    {
        public void Configure(EntityTypeBuilder<LanguageDirectionality> builder)
        {
            builder.Property(ld => ld.Name).IsRequired(true);
            builder.HasIndex(ld => ld.Name).IsUnique();

            builder.HasData(new []
            {
                new LanguageDirectionality{Id = 0, Name = "RTL | راست به چپ", IsDefault = true}, //0: Right to Left
                new LanguageDirectionality{Id = 1, Name = "LTR | چپ به راست"},                   //1: Left to Right
                new LanguageDirectionality{Id = 2, Name = "TTB | بالا به پایین"}                  //2: Top to Bottom
            });
        }
    }
}
