using Agap2it.Labs.RestaurantManager.Data.Contexts;
using Agap2it.Labs.RestaurantManager.Data.Entities;
using Agap2it.Labs.RestaurantManager.DataAccess.Base;

namespace Agap2it.Labs.RestaurantManager.DataAccess.DataAccessObjects
{
    public class DishDataAccessObject : RestaurantManagerDataAccessObject<Dish>
    {
        public DishDataAccessObject(RestaurantContext ctx) : base(ctx)
        {
        }
    }
}
