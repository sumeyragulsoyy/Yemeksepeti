using Microsoft.EntityFrameworkCore;
using Yemeksepeti.Models;

namespace Yemeksepeti.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
       
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommunicationInfo> CommunicationInfos { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<CustomerRegion> CustomerRegions { get; set; }
        public DbSet<RestaurantRegion> RestaurantRegions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<RestaurantRegion>()
                .HasKey(cs => new { cs.RestaurantId,cs.RegionId});
                
            modelBuilder.Entity<CustomerRegion>()
                .HasKey(c => new {c.CustomerId,c.RegionId});
            
            modelBuilder.Entity<User>()
                .Property(user => user.Role).HasDefaultValue("Customer");

        }


    }
}