using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    /// <summary>
    /// The user profile.
    /// </summary>
    public class UserProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile"/> class.
        /// </summary>
        public UserProfile()
        {
            CreateMap<User, UserReadDto>();
        }
    }
}
