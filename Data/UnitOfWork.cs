using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// The unit of work.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
    /// </remarks>
    /// <param name="dbContext">The db context.</param>
    public class UnitOfWork(MyDbContext dbContext) : IUnitOfWork
    {
        /// <summary>
        /// The db context.
        /// </summary>
        private readonly MyDbContext _dbContext = dbContext;


        #region Syncronous
        public void Commit() => _dbContext.SaveChanges();
        public void Rollback() =>  _dbContext.Dispose();      

        #endregion


        #region Asyncronous
        public async void CommitAsync() => await _dbContext.SaveChangesAsync();
        public async void RollbackAsync() => await _dbContext.DisposeAsync();


        #endregion

    }
}
