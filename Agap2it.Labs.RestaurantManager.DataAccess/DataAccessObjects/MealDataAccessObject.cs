using Agap2it.Labs.RestaurantManager.Data.Contexts;
using Agap2it.Labs.RestaurantManager.Data.Entities;
using Agap2it.Labs.RestaurantManager.DataAccess.Base;

namespace Agap2it.Labs.RestaurantManager.DataAccess.DataAccessObjects
{
    public class MealDataAccessObject : RestaurantManagerDataAccessObject<Meal>
    {
        public MealDataAccessObject(RestaurantContext ctx) : base(ctx)
        {
        }
    }
}
