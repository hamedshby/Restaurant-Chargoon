using Microsoft.EntityFrameworkCore;
using RestaurantChargoon.Domain.Entities;

namespace RestaurantChargoon.Infrastructure.EF.Context
{
    public class RestaurantDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server=.;initial catalog=Restaurant;integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        
    }


    
    
}
