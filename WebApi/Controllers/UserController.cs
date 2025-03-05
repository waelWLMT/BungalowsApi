using AutoMapper;
using BLL.IServices;
using Core.Dtos;
using Core.Enums;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }


        [HttpGet]
        public List<UserReadDto> GetALLPatientAccount()
        {
            var accounts = _userService.GetBy(x=> x.RoleId == (int) UserRole.Patient, x=> x.Role);

            var result = _mapper.Map<List<UserReadDto>>(accounts);

            return result;
        }
    }
}
