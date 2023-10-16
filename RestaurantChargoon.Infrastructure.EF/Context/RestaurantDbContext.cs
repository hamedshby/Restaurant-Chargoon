using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.Domain.Enums;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantChargoon.Infrastructure.EF.Context
{
	// Add 2
    public class RestaurantDbContext : DbContext
	{
        public RestaurantDbContext()
        {
        }

        public RestaurantDbContext(DbContextOptions options) : base(options)
        {
        }

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

			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				if (entityType.ClrType.GetProperty("IsDeleted") != null)
				{
					modelBuilder.Entity(entityType.ClrType)
						.Property("IsDeleted")
						.HasDefaultValueSql("0");
				}
				if (entityType.ClrType.GetProperty("IsDeleted") != null)
				{
					var isDeletedProp = entityType.ClrType.GetProperty("IsDeleted");
					var param = Expression.Parameter(entityType.ClrType, "e");
					var body = Expression.Equal(Expression.Property(param, isDeletedProp), Expression.Constant(false));
					modelBuilder.Entity(entityType.ClrType).HasQueryFilter(Expression.Lambda(body, param));
				}
			}

			modelBuilder.Entity<Food>()
				.Property(f => f.FoodType)
				.HasConversion(new EnumToStringConverter<FoodType>());

			modelBuilder.Entity<User>()
				.Property(f => f.UserType)
				.HasConversion(new EnumToStringConverter<UserType>());

		//	modelBuilder.Entity<Factor>()
		//.HasOne(f => f.Restaurant)
		//.WithMany()
		//.HasForeignKey(f => f.RestaurantId);

		//	modelBuilder.Entity<Factor>()
		//		.HasMany(f => f.FactorDetails)
		//		.WithOne(fd => fd.Factor)
		//		.HasForeignKey(fd => fd.FactorId);

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

		public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
		{
			var entries = ChangeTracker
				.Entries()
				.Where(e => e.Entity is BaseEntity && (
						e.State == EntityState.Added
						|| e.State == EntityState.Modified));

			foreach (var entityEntry in entries)
			{
				((BaseEntity)entityEntry.Entity).UpdateDate = DateTime.Now;

				if (entityEntry.State == EntityState.Added)
				{
					((BaseEntity)entityEntry.Entity).CreateDate = DateTime.Now;
				}
			}
			return (await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken));
		}
	}
}


