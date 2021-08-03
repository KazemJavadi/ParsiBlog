using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            builder.Property(r => r.FullName).IsRequired();
            builder.Property(r => r.Text).IsRequired();
            builder.Property(r => r.IP).IsRequired();
        }
    }
}
