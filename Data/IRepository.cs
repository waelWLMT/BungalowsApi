using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<T> where T : class
    {
        #region Syncronous

        #region Read
        T GetById(object id);
        List<T> GetAll();
        List<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        #endregion

        #region Write
        T Insert(T entity);
        void InsertAll(List<T> entities);

        bool Delete(T entity);
        bool DeleteAll(List<T> entities);
        T Update(T entity);
        #endregion

        #endregion


        #region ASyncronous

        #region Read
        Task<T> GetByIdAsync(object id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> FindByAync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        #endregion

        #region Write
        Task<T> InsertAsync(T entity);
        Task<List<T>> InsertAllAsync(List<T> entities);
        Task<bool> DeleteAsync(T entity);       
        
        #endregion

        #endregion
    }
}
