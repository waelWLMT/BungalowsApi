using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    /// <summary>
    /// The entity profile.
    /// </summary>
    public class EntityProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityProfile"/> class.
        /// </summary>
        public EntityProfile()
        {
            CreateMap<Entity, EntityReadDto>();
        }
    }
}
