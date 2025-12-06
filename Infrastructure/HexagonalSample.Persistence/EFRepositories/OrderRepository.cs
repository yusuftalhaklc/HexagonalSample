using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFData;
using Microsoft.EntityFrameworkCore;

namespace HexagonalSample.Persistence.EFRepositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(MyContext context) : base(context)
        {
        }

        public override async Task<List<Order>> GetAllAsync()
        {
            return await _dbSet
                .Include(o => o.AppUser)
                .ToListAsync();
        }

        public override async Task<Order> GetByIdAsync(int id)
        {
            return await _dbSet
                .Include(o => o.AppUser)
                .FirstOrDefaultAsync(o => o.Id == id);
        }
    }
}
