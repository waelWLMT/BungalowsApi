using Core.Models;

namespace WebApi.Utils
{
    public interface IAuthenticationService
    {
        public User Authenticate();
    }
}
