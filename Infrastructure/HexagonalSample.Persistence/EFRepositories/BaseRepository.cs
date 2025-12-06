using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFData;
using Microsoft.EntityFrameworkCore;

namespace HexagonalSample.Persistence.EFRepositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly MyContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(MyContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
