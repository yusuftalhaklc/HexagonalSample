using AutoMapper;
using HexagonalSample.Application.DtoClasses.AppUsers;
using HexagonalSample.Application.DtoClasses.Requests;

namespace HexagonalSample.Application.Mappings
{
    public class AppUserMappingProfile : Profile
    {
        public AppUserMappingProfile()
        {
            CreateMap<CreateAppUserRequest, CreateAppUserCommand>();
            CreateMap<UpdateAppUserRequest, UpdateAppUserCommand>();
        }
    }
}
