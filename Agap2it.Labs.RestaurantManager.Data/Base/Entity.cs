using System.ComponentModel.DataAnnotations;

namespace Agap2it.Labs.RestaurantManager.Data.Base
{
    public class Entity
    {
        [Key]
        public long Id { get; set; }

        public Guid Guid { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; private set; }
        public DateTime DeletedAt { get; private set; }

        public bool IsDeletedAt => DeletedAt != DateTime.MinValue;

        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        public void Delete()
        {
            DeletedAt = DateTime.UtcNow;
        }
    }
}
