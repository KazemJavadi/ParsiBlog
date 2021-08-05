using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Entity.Config
{
    class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasIndex(p => p.Title);
            builder.Property(p => p.ImageUrl).IsUnicode(false);
            builder.HasIndex(p => p.IsPublished);
            builder.HasIndex(p => p.PublishDate);
            builder.HasIndex(p => p.IsSoftDeleted);
        }
    }
}
