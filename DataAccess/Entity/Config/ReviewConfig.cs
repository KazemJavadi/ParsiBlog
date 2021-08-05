using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Entity.Config
{
    class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasOne(r => r.ReplyTo)
                .WithMany(r => r.Replies)
                .HasForeignKey(r => r.ReplyToId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder
            //    .HasOne(r => r.Post)
            //    .WithMany(p => p.Reviews)
            //    .HasForeignKey(r => r.PostId)
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
