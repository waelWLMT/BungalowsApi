using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.IServices;
using Core.Models;
using Data;
using Data.IRepositories;
using Data.Repositories;

namespace BLL.Services
{
    public class CommercialService : ServicePattern<Commercial>, ICommercialService
    {
        public CommercialService(ICommercialRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
