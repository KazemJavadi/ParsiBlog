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
            builder.Property(post => post.Title).HasMaxLength(500);
            builder.HasIndex(post => post.Title);
            builder.Property(post => post.Title).IsRequired(true);

            builder.Property(post => post.ImageUrl).IsRequired(false);
            builder.Property(post => post.ImageUrl).HasMaxLength(200); /*guid-datetime-rand.extension*/
            builder.Property(post => post.ImageUrl).IsUnicode(false);

            builder.Property(post=>post.Text).
        }
    }
}
