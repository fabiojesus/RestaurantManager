using Agap2it.Labs.RestaurantManager.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class Menu : Entity
    {

        private DateTime _date;

        public DateTime Date 
        { 
            get => _date;
            set
            {
                _date = value;
                Update();
            } 
        }

        public virtual ICollection<MealDish> Dishes { get; set; }

        public long RestaurantId { get; set; }

        [ForeignKey(nameof(RestaurantId))]
        public virtual Restaurant Restaurant { get; set; }
    }
}
