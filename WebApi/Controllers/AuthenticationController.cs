using AutoMapper;
using Core.Dtos;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Utils;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService, IMapper mapper)
        {
            _mapper = mapper;
            _authenticationService = authenticationService;
        }

        public UserReadDto Authenticate()
        {
            var user = _authenticationService.Authenticate();
            var result = _mapper.Map<UserReadDto>(user);

            return result;

        }
    }
}
