using HexagonalSample.Application.DtoClasses.AppUsers;
using HexagonalSample.Application.PrimaryPorts.AppUserPorts;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserUseCases
{
    public class CreateAppUserUseCase : ICreateAppUserUseCase
    {
        private readonly IAppUserRepository _repository;

        public CreateAppUserUseCase(IAppUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(CreateAppUserCommand command)
        {
            AppUser appUser = new()
            {
                UserName = command.UserName,
                Password = command.Password,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            };

            await _repository.CreateAsync(appUser);
        }
    }
}
