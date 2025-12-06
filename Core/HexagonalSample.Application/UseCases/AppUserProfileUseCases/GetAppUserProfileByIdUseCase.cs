

using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserProfileUseCases
{
    public class GetAppUserProfileByIdUseCase : IGetAppUserProfileByIdUseCase
    {
        private readonly IAppUserProfileRepository _repository;

        public GetAppUserProfileByIdUseCase(IAppUserProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task<AppUserProfileResult> Handle(GetAppUserProfileByIdQuery request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request);
        }

        public async Task<AppUserProfileResult> ExecuteAsync(GetAppUserProfileByIdQuery query)
        {
            var profile = await _repository.GetByIdAsync(query.Id);
            if (profile == null)
                throw new Exception($"AppUserProfile with id {query.Id} not found");

            return new AppUserProfileResult
            {
                Id = profile.Id,
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                AppUserId = profile.AppUserId,
                CreatedDate = profile.CreatedDate,
                UpdatedDate = profile.UpdatedDate
            };
        }
    }
}
