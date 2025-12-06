using HexagonalSample.Application.DtoClasses.AppUsers;
using HexagonalSample.Application.PrimaryPorts.AppUserPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserUseCases
{
    public class GetAllAppUsersUseCase : IGetAllAppUsersUseCase
    {
        private readonly IAppUserRepository _repository;

        public GetAllAppUsersUseCase(IAppUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<AppUserResult>> Handle(GetAllAppUsersQuery request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request);
        }

        public async Task<List<AppUserResult>> ExecuteAsync(GetAllAppUsersQuery query)
        {
            var appUsers = await _repository.GetAllAsync();

            return appUsers.Select(u => new AppUserResult
            {
                Id = u.Id,
                UserName = u.UserName,
                Password = u.Password,
                CreatedDate = u.CreatedDate,
                UpdatedDate = u.UpdatedDate
            }).ToList();
        }
    }
}
