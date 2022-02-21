using Agap2it.Labs.RestaurantManager.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class Region : NamedEntity
    {

        private long _countryId;
        public long CountryId 
        { 
            get => _countryId;
            set
            {
                _countryId = value;
                Update();
            } 
        }

        [ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }

    }
}
