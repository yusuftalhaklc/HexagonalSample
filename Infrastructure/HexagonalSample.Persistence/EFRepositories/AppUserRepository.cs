using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFData;

namespace HexagonalSample.Persistence.EFRepositories
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(MyContext context) : base(context)
        {
        }
    }
}
