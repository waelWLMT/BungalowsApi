using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BLL.IServices;
using Core.Dtos;
using Core.Utils;
using Microsoft.IdentityModel.Tokens;

namespace BLL.Utils
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;
        private readonly IPasswordEnryptorDecryptor _passwordEncryptor;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly MyConfiguration _myConfiguration;

        public AuthService(IUserService userService,
            IPasswordEnryptorDecryptor passwordEncryptor,
            IJwtTokenGenerator jwtTokenGenerator,
            MyConfiguration myConfiguration)
        {
            _userService = userService;
            _passwordEncryptor = passwordEncryptor;
            _jwtTokenGenerator = jwtTokenGenerator;
            _myConfiguration = myConfiguration;
        }
        public AuthEntityModel Authenticate(string login, string password)
        {
            var user = _userService.GetByEmailOrLogin(login);
            if (user != null && _passwordEncryptor.Decrypt(user.CryptedPassword, _myConfiguration.PasswordCryptorKey) == password)
            {                
                var authEntity = new AuthEntityModel
                {
                    User = user,
                    Token = _jwtTokenGenerator.GenerateToken(user.Nom + user.Prenom)
                };

                return authEntity;
            }

            return null;
        }     

    }
}
