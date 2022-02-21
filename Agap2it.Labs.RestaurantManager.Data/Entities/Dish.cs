using Agap2it.Labs.RestaurantManager.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class Dish : NamedEntity
    {
        private string _description;

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                Update();
            }
        }

        private long _dishTypeId;

        public long DishTypeId
        {
            get => _dishTypeId;
            set
            {
                _dishTypeId = value;
                Update();
            }
        }

        [ForeignKey(nameof(DishTypeId))]
        public virtual DishType DishType { get; set; }
    }
}
