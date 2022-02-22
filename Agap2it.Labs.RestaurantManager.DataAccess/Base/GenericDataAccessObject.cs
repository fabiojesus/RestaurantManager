
using Agap2it.Labs.RestaurantManager.Data.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Agap2it.Labs.RestaurantManager.DataAccess.Base
{
    public class GenericDataAccessObject<TContext, TUser> where TContext : IdentityDbContext<TUser, IdentityRole<long>, long>, new()
                                                          where TUser : IdentityUser<long>
    {
        private readonly TContext _context;

        public GenericDataAccessObject(TContext ctx)
        {
            _context = ctx;
        }

        public async Task<IEnumerable<TEntity>> ListAsync<TEntity>() where TEntity : Entity
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> ListNonDeletedAsync<TEntity>() where TEntity : Entity
        {
            return await _context.Set<TEntity>().Where(x => !x.IsDeletedAt).ToListAsync();
        }

        public async Task DeleteAsync<TEntity>(TEntity item) where TEntity : Entity
        {
            item.Delete();
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync<TEntity>(TEntity item) where TEntity : Entity
        {
            _context.Set<TEntity>().Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity?> GetAsync<TEntity>(Guid id) where TEntity : Entity
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(t => t.Uuid == id);
        }

        public async Task<bool> Any<TEntity>(Expression<Func<TEntity, bool>> condition) where TEntity : Entity
        {
            return (await _context.Set<TEntity>().Where(condition).ToListAsync()).Any();
        }
    }
}
