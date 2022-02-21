using Agap2it.Labs.RestaurantManager.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class MealDish : Entity
    {

        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                Update();
            }
        }

        private long _mealId;

        public long MealId
        {
            get => _mealId;
            set 
            {
                _mealId = value;
                Update();
            }
        }

        [ForeignKey(nameof(MealId))]
        public virtual Meal Meal { get; set; }


        private long _dishId;

        public long DishId
        {
            get => _dishId;
            set
            {
                _dishId = value;
                Update();
            }
        }

        [ForeignKey(nameof(DishId))]
        public virtual Dish Dish { get; set; }
    }
}
