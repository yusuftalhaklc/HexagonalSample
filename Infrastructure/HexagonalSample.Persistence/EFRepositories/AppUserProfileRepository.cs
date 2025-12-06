using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFData;

namespace HexagonalSample.Persistence.EFRepositories
{
    public class AppUserProfileRepository : BaseRepository<AppUserProfile>, IAppUserProfileRepository
    {
        public AppUserProfileRepository(MyContext context) : base(context)
        {
        }
    }
}
