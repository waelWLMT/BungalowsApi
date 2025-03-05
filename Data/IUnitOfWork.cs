using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUnitOfWork
    {
        #region Syncronous
        void Commit();
        void Rollback();
        #endregion

        #region Asyncronous
        void CommitAsync();
        void RollbackAsync();
        #endregion

    }
}
