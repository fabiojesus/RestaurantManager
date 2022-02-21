using Agap2it.Labs.RestaurantManager.Data.Contexts;

var context = new RestaurantContext();
context.Database.EnsureDeleted();
context.Database.EnsureCreated();