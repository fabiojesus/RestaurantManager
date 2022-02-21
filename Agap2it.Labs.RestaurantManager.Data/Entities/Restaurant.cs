using Agap2it.Labs.RestaurantManager.Data.Base;
using Newtonsoft.Json;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class Restaurant : Entity
    {
        private string _address;

        public string Address
        {
            get => _address;
            set
            {
                _address = value;
                Update();
            }
        }

        public virtual ICollection<Menu> Menu { get; set; }

        private bool _active;

        public bool Active
        {
            get => _active;
            set
            {
                _active = value;
                Update();
            }
        }

        private string _description;

        public string Description
        {
            get=> _description;
            set
            {
                _description = value;
                Update();
            }
        }

    }
}
