using DataAccess.Entity.Config;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    static class AppDbContextExtensions
    {
        public static void ConfigAppDbContextEntities(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostConfig());
            modelBuilder.ApplyConfiguration(new ReviewConfig());
            modelBuilder.ApplyConfiguration(new TagConfig());
            modelBuilder.ApplyConfiguration(new PostTagConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new PostCategoryConfig());
        }
    }
}
