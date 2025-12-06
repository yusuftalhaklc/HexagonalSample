using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserProfileUseCases
{
    public class GetAllAppUserProfilesUseCase : IGetAllAppUserProfilesUseCase
    {
        private readonly IAppUserProfileRepository _repository;

        public GetAllAppUserProfilesUseCase(IAppUserProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<AppUserProfileResult>> Handle(GetAllAppUserProfilesQuery request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request);
        }

        public async Task<List<AppUserProfileResult>> ExecuteAsync(GetAllAppUserProfilesQuery query)
        {
            var profiles = await _repository.GetAllAsync();

            return profiles.Select(p => new AppUserProfileResult
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                AppUserId = p.AppUserId,
                CreatedDate = p.CreatedDate,
                UpdatedDate = p.UpdatedDate
            }).ToList();
        }
    }
}
