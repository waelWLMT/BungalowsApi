using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.IServices;
using Core.Models;
using Data;
using Data.IRepositories;

namespace BLL.Services
{
    public class AdminService : ServicePattern<Admin>, IAdminService
    {
        public AdminService(IAdminRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
