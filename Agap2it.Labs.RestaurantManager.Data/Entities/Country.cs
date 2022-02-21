using Agap2it.Labs.RestaurantManager.Data.Base;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class Country : NamedEntity
    {
        public virtual ICollection<Region> Regions { get; set; }

    }
}
