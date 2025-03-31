using AutoMapper;
using Core.Dtos;

namespace WebApi.Profiles
{
    public class AuthEntityProfile : Profile
    {
        public AuthEntityProfile()
        {
            CreateMap<AuthEntityModel, AuthEntityReadDto>();
        }
    }
}
