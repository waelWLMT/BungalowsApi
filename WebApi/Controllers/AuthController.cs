using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using BLL.Utils;
using Core.Dtos;
using Core.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;



namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public AuthController(IAuthService authService, IMapper mapper)
        {            
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public IActionResult Login(UserIdentity user)
        {        

            var authEntity = _authService.Authenticate(user.LoginEmail, user.Password);
            if (authEntity != null)
                return Ok(_mapper.Map<AuthEntityReadDto>(authEntity));

            return Unauthorized();
        }
    }
}
