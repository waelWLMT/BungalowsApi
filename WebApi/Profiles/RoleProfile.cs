using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    /// <summary>
    /// The role profile.
    /// </summary>
    public class RoleProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleProfile"/> class.
        /// </summary>
        public RoleProfile()
        {
            CreateMap<Role, RoleReadDto>();
        }
    }
}
