using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Data.IRepositories;

namespace Data.Repositories
{
    public class ProprietaireRepository : Repository<Proprietaire>, IProprietaireRepository
    {
        public ProprietaireRepository(MyDbContext ctx) : base(ctx)
        {
        }
    }
}
