using Agap2it.Labs.RestaurantManager.Data.Base;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class DishType : NamedEntity
    {
        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
