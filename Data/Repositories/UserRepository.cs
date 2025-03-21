using Core.Models;
using Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    /// <summary>
    /// The user repository.
    /// </summary>
    public class UserRepository : Repository<User>, IUserRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="ctx">The ctx.</param>
        public UserRepository(MyDbContext ctx) : base(ctx)
        {

        }

        public User GetUserByLoginOrEmail(string loginOrEmail)
        {
#pragma warning disable CS8603 // Existence possible d'un retour de référence null.
            return base.
                _dbSet
                .FirstOrDefault(x => x.Email == loginOrEmail || x.Login == loginOrEmail);
#pragma warning restore CS8603 // Existence possible d'un retour de référence null.
        }
    }
}
