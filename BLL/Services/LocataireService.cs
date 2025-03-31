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
    public class LocataireService : ServicePattern<Locataire>, ILocataireService
    {
        public LocataireService(ILocataireRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
