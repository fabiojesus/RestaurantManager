using Agap2it.Labs.RestaurantManager.Data.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Agap2it.Labs.RestaurantManager.DataAccess.Base
{
    public abstract class BaseDataAccessObject<TContext, TEntity, TUser> where TContext: IdentityDbContext<TUser, IdentityRole<long>, long>, new() 
                                                                  where TEntity : Entity where TUser: IdentityUser<long>
    {
        private readonly TContext _context;

        protected BaseDataAccessObject(TContext ctx)
        {
            _context = ctx;
        }

        public async Task<IEnumerable<TEntity>> ListAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> ListNonDeletedAsync()
        {
            return await _context.Set<TEntity>().Where(x=>!x.IsDeletedAt).ToListAsync();
        }


        public async Task InsertAsync(TEntity item)
        {
            await _context.Set<TEntity>().AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity item)
        {
            item.Delete();
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity item)
        {
            _context.Set<TEntity>().Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity?> GetAsync(Guid id)
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(t => t.Uuid == id);
        }

        public async Task<bool> Any(Expression<Func<TEntity, bool>> condition)
        {
            return (await _context.Set<TEntity>().Where(condition).ToListAsync()).Any();
        }
    }
}
