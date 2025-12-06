using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFData;
using Microsoft.EntityFrameworkCore;

namespace HexagonalSample.Persistence.EFRepositories
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(MyContext context) : base(context)
        {
        }

        public override async Task<List<OrderDetail>> GetAllAsync()
        {
            return await _dbSet
                .Include(od => od.Product)
                .ToListAsync();
        }

        public override async Task<OrderDetail> GetByIdAsync(int id)
        {
            return await _dbSet
                .Include(od => od.Product)
                .FirstOrDefaultAsync(od => od.Id == id);
        }
    }
}
