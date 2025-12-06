using HexagonalSample.Application.DtoClasses.AppUsers;
using HexagonalSample.Application.PrimaryPorts.AppUserPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserUseCases
{
    public class UpdateAppUserUseCase : IUpdateAppUserUseCase
    {
        private readonly IAppUserRepository _repository;

        public UpdateAppUserUseCase(IAppUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(UpdateAppUserCommand command)
        {
            var appUser = await _repository.GetByIdAsync(command.Id);
            if (appUser == null)
                throw new Exception($"AppUser with id {command.Id} not found");

            appUser.UserName = command.UserName;
            appUser.Password = command.Password;
            appUser.UpdatedDate = DateTime.Now;
            appUser.Status = Domain.Enums.DataStatus.Updated;

            await _repository.UpdateAsync(appUser);
        }
    }
}
