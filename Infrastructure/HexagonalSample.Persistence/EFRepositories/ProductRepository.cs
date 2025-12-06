using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFData;
using Microsoft.EntityFrameworkCore;

namespace HexagonalSample.Persistence.EFRepositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(MyContext context) : base(context)
        {
        }

        public override async Task<List<Product>> GetAllAsync()
        {
            return await _dbSet
                .Include(p => p.Category)
                .ToListAsync();
        }

        public override async Task<Product> GetByIdAsync(int id)
        {
            return await _dbSet
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
