using HexagonalSample.Application.DtoClasses.AppUsers;
using HexagonalSample.Application.PrimaryPorts.AppUserPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserUseCases
{
    public class GetAppUserByIdUseCase : IGetAppUserByIdUseCase
    {
        private readonly IAppUserRepository _repository;

        public GetAppUserByIdUseCase(IAppUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<AppUserResult> Handle(GetAppUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request);
        }

        public async Task<AppUserResult> ExecuteAsync(GetAppUserByIdQuery query)
        {
            var appUser = await _repository.GetByIdAsync(query.Id);
            if (appUser == null)
                throw new Exception($"AppUser with id {query.Id} not found");

            return new AppUserResult
            {
                Id = appUser.Id,
                UserName = appUser.UserName,
                Password = appUser.Password,
                CreatedDate = appUser.CreatedDate,
                UpdatedDate = appUser.UpdatedDate
            };
        }
    }
}
