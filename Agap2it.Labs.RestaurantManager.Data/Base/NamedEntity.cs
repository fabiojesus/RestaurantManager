
namespace Agap2it.Labs.RestaurantManager.Data.Base
{
    public class NamedEntity : Entity
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Update();
            }
        }
    }
}
