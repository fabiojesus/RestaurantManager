using Agap2it.Labs.RestaurantManager.Data.Base;
using Agap2it.Labs.RestaurantManager.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Agap2it.Labs.RestaurantManager.Data.Contexts
{
    public class RestaurantContext : IdentityDbContext<RestaurantUser, IdentityRole<long>, long>
    {


        #region Sets
        public DbSet<Country> Countries { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDish> MealDishes { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Profile> Regions { get; set; }
        public DbSet<Profile> Restaurants { get; set; }
        #endregion

        #region Constructors

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) {}
        public RestaurantContext() : base() {}

        #endregion

        #region Setup
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                                   .SetBasePath(Directory.GetCurrentDirectory())
                                   .AddJsonFile("appsettings.json").Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var types = new List<Type>() {typeof(Country), typeof(Dish), typeof(DishType), typeof(Meal), typeof(MealDish), typeof(MealType),
                                             typeof(Menu), typeof(Profile), typeof(Region), typeof(Restaurant)};

            foreach(var type in types)
            {
                modelBuilder.Entity(type).HasIndex("Uuid").IsUnique(true);
                modelBuilder.Entity(type).Property("Uuid").HasDefaultValueSql("newid()");
            }



            
        }
        #endregion
    }
}
