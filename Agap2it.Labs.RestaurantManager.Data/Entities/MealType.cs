
using Agap2it.Labs.RestaurantManager.Data.Base;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class MealType : NamedEntity
    {
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
