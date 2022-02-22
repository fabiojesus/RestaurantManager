using Agap2it.Labs.RestaurantManager.Data.Base;
using Agap2it.Labs.RestaurantManager.Data.Contexts;
using Agap2it.Labs.RestaurantManager.Data.Entities;

namespace Agap2it.Labs.RestaurantManager.DataAccess.Base
{
    public class RestaurantManagerDataAccessObject<TEntity> : BaseDataAccessObject<RestaurantContext, TEntity, RestaurantUser> where TEntity : Entity
    {
        public RestaurantManagerDataAccessObject(RestaurantContext ctx) : base(ctx)
        {
        }
    }
}
