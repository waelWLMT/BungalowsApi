using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class LocataireProfile : Profile
    {
        public LocataireProfile()
        {
            CreateMap<UserCreateDto, Locataire>();
        }
    }
}
