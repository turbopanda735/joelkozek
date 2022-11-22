using Microsoft.EntityFrameworkCore;

namespace joelkozek.comapi2.Models.Review
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions<ReviewContext> options) : base(options)
        {
        }
        public DbSet<ReviewModel> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReviewModel>().ToTable("Reviews");
        }
    }
}
