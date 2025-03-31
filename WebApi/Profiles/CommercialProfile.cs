using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class CommercialProfile : Profile
    {
        public CommercialProfile()
        {
            CreateMap<UserCreateDto, Commercial>();
        }
    }
}
