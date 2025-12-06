using AutoMapper;
using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using HexagonalSample.Application.DtoClasses.Requests;

namespace HexagonalSample.Application.Mappings
{
    public class AppUserProfileMappingProfile : Profile
    {
        public AppUserProfileMappingProfile()
        {
            CreateMap<CreateAppUserProfileRequest, CreateAppUserProfileCommand>();
            CreateMap<UpdateAppUserProfileRequest, UpdateAppUserProfileCommand>();
        }
    }
}
