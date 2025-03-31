using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class ProprietaireProfile : Profile
    {
        public ProprietaireProfile()
        {
            CreateMap<UserCreateDto, Proprietaire>();
        }
    }
}
