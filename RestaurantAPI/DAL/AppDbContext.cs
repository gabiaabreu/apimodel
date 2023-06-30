using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Domain.Entity;

namespace RestaurantAPI.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(x => x.Dish).IsUnicode(false);
                entity.Property(x => x.Description).IsUnicode(false);
                entity.Property(x => x.Price).IsUnicode(false);
            });
        }
    }
}
