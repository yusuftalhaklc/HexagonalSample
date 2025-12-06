using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFData;

namespace HexagonalSample.Persistence.EFRepositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(MyContext context) : base(context)
        {
        }
    }
}
