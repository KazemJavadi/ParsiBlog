using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity.Config
{
    class PostConfig : IEntityTypeConfiguration<Post>
    {
        private const int MaxTitleSize = 500;
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasIndex(p => p.Title);
            builder.Property(p => p.Title).IsRequired(true);

            builder.Property(p => p.ImageUrl).IsRequired(false);
            builder.Property(p => p.ImageUrl).IsUnicode(false);

            builder.Property(p => p.Text).IsRequired(true);

            builder.HasIndex(p => p.IsPublished);

            builder.Property(p => p.PublishDate).IsRequired();
            builder.HasIndex(p => p.PublishDate);

            builder.Property(p => p.LastEditeDate).IsRequired();

            builder.HasIndex(p => p.IsSoftDeleted);
        }
    }
}
