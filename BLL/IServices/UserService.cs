using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Data;
using Data.IRepositories;
using Data.Repositories;

namespace BLL.IServices
{
    public class UserService : ServicePattern<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork) : base(userRepository, unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public User GetUserByLoginOrEmail(string loginOrEmail)
        {
            return _userRepository.GetUserByLoginOrEmail(loginOrEmail);
        }
    }
}
