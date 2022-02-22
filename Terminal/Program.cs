using Agap2it.Labs.RestaurantManager.Data.Contexts;
using Agap2it.Labs.RestaurantManager.Data.Entities;
using Agap2it.Labs.RestaurantManager.DataAccess.Base;

var ctx = new RestaurantContext();
//ctx.Database.EnsureDeleted();
//ctx.Database.EnsureCreated();
var cdao = new CountryDataAccessObject(ctx);

//var country = new Country() { Name = "Portugal"};

//cdao.InsertAsync(country).Wait();
var item = cdao.ListAsync().Result;
var it = item.First();
it.Name = "Espanha";
cdao.UpdateAsync(it).Wait();
Console.WriteLine();