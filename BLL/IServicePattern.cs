using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IServicePattern<T> where T : class
    {

        #region Syncronous
       
        
        #region Read

        T GetById(object id);
        List<T> GetAll();
        List<T> GetBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        #endregion

        #region Write

        T Insert(T entity);
        List<T> InsertAll(List<T> entities);

        bool Delete(T entity);
        bool DeleteAll(List<T> entities);

        T Update(T entity);
        List<T> UpdateAll(List<T> entities);        


        #endregion


        #endregion


        #region Asyncronous




        #region Read

        Task<T> GetByIdAsync(object id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetByAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);


        #endregion

        #region Write

        Task<T> InsertAsync(T entity);
        Task<List<T>> InsertAllAsync(List<T> entities);

        Task<bool> DeleteAsync(T entity);
        Task<bool> DeleteAllAsync(List<T> entities);

        Task<T> UpdateAsync(T entity);
        Task<List<T>> UpdateAllAsync(List<T> entities);  

        #endregion


        #endregion


    }
}
