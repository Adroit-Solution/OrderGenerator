using MarketPlace_Orders.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace_Orders.Database
{
    public class MarketPlaceContext:DbContext
    {
        public MarketPlaceContext(DbContextOptions<MarketPlaceContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestaurantMarketPlace>().HasKey(c => new { c.MarketPlace, c.Restaurant });
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<DeliveryBoy> DeliveryBoys { get; set; }
        public DbSet<MarketPlace> MarketPlaces { get; set; }
        public DbSet<RestaurantMarketPlace> RestMarketRelate { get; set; }
    }
}
