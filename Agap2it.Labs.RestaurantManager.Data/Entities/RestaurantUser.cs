using Microsoft.AspNetCore.Identity;

namespace Agap2it.Labs.RestaurantManager.Data.Entities
{
    public class RestaurantUser : IdentityUser<long>
    {
        public virtual Profile Profile { get; set; }  
    }
}
