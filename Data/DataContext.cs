using Microsoft.EntityFrameworkCore;
using Yemeksepeti.Models;

namespace Yemeksepeti.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Address> Addresses {get; set;}
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommunicationInfo> CommunicationInfos { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }   
        public DbSet<Product> Products { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Customer>().HasData(
                new Customer {Id=1,Name="Sumeyra"}
            );
           
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant{Id=1,Name="Dominos"}

            );

            modelBuilder.Entity<Address>().HasData(
                new Address {Id=1,Country="Turkey",CustomerId=1}
            );

            
        }

        
    }
}