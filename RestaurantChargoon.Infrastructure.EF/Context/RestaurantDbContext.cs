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
		public DbSet<Factor> Factors { get; set; }
		public DbSet<FactorDetail> FactorDetails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Food>()
				.Property(f => f.FoodType)
				.HasConversion(new EnumToStringConverter<FoodType>());

			modelBuilder.Entity<User>()
				.Property(f => f.UserType)
				.HasConversion(new EnumToStringConverter<UserType>());

			modelBuilder.Entity<Factor>()
		.HasOne(f => f.Restaurant)
		.WithMany()
		.HasForeignKey(f => f.RestaurantId);

			modelBuilder.Entity<Factor>()
				.HasMany(f => f.FactorDetails)
				.WithOne(fd => fd.Factor)
				.HasForeignKey(fd => fd.FactorId);

			modelBuilder.Entity<Factor>()
		.HasOne(f => f.User)
		.WithMany()
		.HasForeignKey(f => f.UserId)
		.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Restaurant>()
				.HasOne(r => r.User)
				.WithMany()
				.HasForeignKey(r => r.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}






}
