using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFData;

namespace HexagonalSample.Persistence.EFRepositories
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(MyContext context) : base(context)
        {
        }
    }
}
