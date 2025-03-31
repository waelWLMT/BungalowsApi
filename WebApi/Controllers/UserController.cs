using AutoMapper;
using BLL.IServices;
using BLL.Utils;
using Core.Dtos;
using Core.Enums;
using Core.Models;
using Core.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;


namespace WebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILocataireService _locataireService;
        private readonly IAdminService _adminService;
        private readonly IProprietaireService _proprietaireService;
        private readonly ICommercialService _commercialService;
        private readonly IPasswordEnryptorDecryptor _passwordEnryptorDecryptor;
        private readonly MyConfiguration _myConfiguration;
        private readonly IMapper _mapper;

        public UserController(
            IUserService userService, IAdminService adminService,
            ILocataireService locataireService, IProprietaireService proprietaireService,
            ICommercialService commercialService, IPasswordEnryptorDecryptor passwordEnryptorDecryptor,
            MyConfiguration myConfiguration,
            IMapper mapper)
        {
            _userService = userService;
            _locataireService = locataireService;
            _adminService = adminService;
            _proprietaireService = proprietaireService;
            _commercialService = commercialService;
            _passwordEnryptorDecryptor = passwordEnryptorDecryptor;
            _myConfiguration = myConfiguration;
            _mapper = mapper;
        }


        [HttpPost("CreateUser")]
        public UserReadDto CreateUser(UserCreateDto userCreateDto)
        {
            var userRole = userCreateDto.RoleId;

            switch (userRole)
            {
                case (int)UserRole.Admin:
                    {
                        var admin = _mapper.Map<Admin>(userCreateDto);
                        admin.CryptedPassword = _passwordEnryptorDecryptor.Encrypt(userCreateDto.Password, _myConfiguration.PasswordCryptorKey);
                        _adminService.Insert(admin);


                        return _mapper.Map<UserReadDto>(admin);
                    }
                case (int)UserRole.Proprietaire:
                    {
                        var proprietaire = _mapper.Map<Proprietaire>(userCreateDto);
                        proprietaire.CryptedPassword = _passwordEnryptorDecryptor.Encrypt(userCreateDto.Password, _myConfiguration.PasswordCryptorKey);

                        _proprietaireService.Insert(proprietaire);

                        return _mapper.Map<UserReadDto>(proprietaire);
                    }

                case (int)UserRole.Commerciale:
                    {
                        var commercial = _mapper.Map<Commercial>(userCreateDto);
                        commercial.CryptedPassword = _passwordEnryptorDecryptor.Encrypt(userCreateDto.Password, _myConfiguration.PasswordCryptorKey);

                        _commercialService.Insert(commercial);

                        return _mapper.Map<UserReadDto>(commercial);
                    }

                default:
                    {
                        var locataire = _mapper.Map<Locataire>(userCreateDto);
                        locataire.CryptedPassword = _passwordEnryptorDecryptor.Encrypt(userCreateDto.Password, _myConfiguration.PasswordCryptorKey);

                        _locataireService.Insert(locataire);

                        return _mapper.Map<UserReadDto>(locataire);
                    }

            }

        }



        [HttpGet("GetAllUsers")]
        [Authorize]
        public List<UserReadDto> GetAllUsers()
        {
            var users = _userService.GetAll();
            var result = _mapper.Map<List<UserReadDto>>(users);

            return result;


        }
    
    
    
    }
}
