using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;

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
        public DbSet<Food> Foods { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Food>()
				.Property(f => f.FoodType)
				.HasConversion(new EnumToStringConverter<FoodType>());

			modelBuilder.Entity<User>()
				.Property(f => f.UserType)
				.HasConversion(new EnumToStringConverter<UserType>());
		}
	}




    
    
}
