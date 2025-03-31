using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Data.IRepositories;

namespace Data.Repositories
{
    public class LocataireRepository : Repository<Locataire>, ILocataireRepository
    {
        public LocataireRepository(MyDbContext ctx) : base(ctx)
        {
        }
    }
}
