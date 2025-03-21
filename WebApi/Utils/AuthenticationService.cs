using BLL.IServices;
using Core.Dtos;
using Core.Models;

namespace WebApi.Utils
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly IPasswordCryptorDecryptor _passwordCryptorDecryptor;

        public AuthenticationService(IUserService userService, IPasswordCryptorDecryptor passwordCryptorDecryptor)
        {
            _userService = userService;
            _passwordCryptorDecryptor = passwordCryptorDecryptor;


        }

        public User Authenticate(UserIdentity userIdentity)
        {
            var user = _userService.GetUserByLoginOrEmail();

            if (user != null && user.CryptedPassword == _passwordCryptorDecryptor.CryptPassword(userIdentity.Password))
                return user;

            return null;
        }
    }
}
