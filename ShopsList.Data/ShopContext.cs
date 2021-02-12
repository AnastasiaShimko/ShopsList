using Microsoft.EntityFrameworkCore;
using ShopsList.Business.Models;

namespace ShopsList.Data
{
    public class ShopContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().HasData(
                new Shop[]
                {
                new Shop { Id=1, Name = "Evroopt", Information = "Info", WorkingHours = "12.00 - 23.00"},
                new Shop { Id=2, Name = "Evroopt 2", Information = "Info 2", WorkingHours = "13.00 - 22.00"},
                new Shop { Id=3, Name = "Evroopt 3", Information = "Info 3", WorkingHours = "10.00 - 21.00"}
                });
        }
    }
}
