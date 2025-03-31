using Core.Dtos;

namespace BLL.Utils
{
    public interface IAuthService
    {
        public AuthEntityModel Authenticate(string login, string password);
    }
}
