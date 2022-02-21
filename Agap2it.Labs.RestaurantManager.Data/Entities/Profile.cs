using Agap2it.Labs.RestaurantManager.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class Profile : Entity
    {
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                Update();
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                Update();
            }
        }

        private long _vatNumber;
        public long VatNumber
        {
            get => _vatNumber;
            set
            {
                _vatNumber = value;
                Update();
            }
        }

        private long _userId;

        public long UserId
        {
            get => _userId;
            set
            {
                _userId = value;
                Update();
            }
        }

        [ForeignKey(nameof(UserId))]
        public virtual RestaurantUser User { get; set; }

    }
}
