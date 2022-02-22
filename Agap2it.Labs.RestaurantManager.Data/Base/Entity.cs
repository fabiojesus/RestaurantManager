using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agap2it.Labs.RestaurantManager.Data.Base
{
    public class Entity
    {
        [Key]
        public long Id { get; set; }

        public Guid Uuid { get; set; }

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

        protected Entity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            DeletedAt = DateTime.MinValue;
        }
    }
}
