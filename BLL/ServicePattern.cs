using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicePattern<T> : IServicePattern<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ServicePattern(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        #region Syncronous


        #region Read

        /// <summary>
        /// Get by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>A T</returns>
        public T GetById(object id)
        {
            return _repository.GetById(id);
        }
        /// <summary>
        /// Get the all.
        /// </summary>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> GetAll()
        {
            return _repository.GetAll();
        }


        /// <summary>
        /// Get the by.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="includes">The includes.</param>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> GetBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return _repository.FindBy(predicate, includes);
        }

        #endregion

        #region Write

        public T Insert(T entity)
        {

            _repository.Insert(entity);
            _unitOfWork.Commit();

            return entity;
        }
        /// <summary>
        /// Inserts the all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> InsertAll(List<T> entities)
        {
            _repository.InsertAll(entities);
            _unitOfWork.Commit();

            return entities;
        }

        public bool Delete(T entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Commit();

            return true;
        }
        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>A bool</returns>
        public bool DeleteAll(List<T> entities)
        {
            _repository.DeleteAll(entities);
            _unitOfWork.Commit();

            return true;
        }

        public T Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.Commit();

            return entity;
        }
        /// <summary>
        /// Update the all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> UpdateAll(List<T> entities)
        {
            _unitOfWork.Commit();
            return entities;
        }




        #endregion


        #endregion


        #region Asyncronous




        #region Read

        /// <summary>
        /// Get by id asynchronously.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns><![CDATA[Task<T>]]></returns>
        public async Task<T> GetByIdAsync(object id)
        {
            return await _repository.GetByIdAsync(id);
        }
        /// <summary>
        /// Get the all asynchronously.
        /// </summary>
        /// <returns><![CDATA[Task<List<T>>]]></returns>
        public async Task<List<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
        /// <summary>
        /// Get the by asynchronously.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="includes">The includes.</param>
        /// <returns><![CDATA[Task<List<T>>]]></returns>
        public async Task<List<T>> GetByAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return await _repository.FindByAync(predicate, includes);
        }


        #endregion

        #region Write

        /// <summary>
        /// Inserts and return a task of type t asynchronously.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns><![CDATA[Task<T>]]></returns>
        public async Task<T> InsertAsync(T entity)
        {
            await _repository.InsertAsync(entity);
            _unitOfWork.CommitAsync();

            return entity;
        }
        /// <summary>
        /// Inserts the all asynchronously.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns><![CDATA[Task<List<T>>]]></returns>
        public async Task<List<T>> InsertAllAsync(List<T> entities)
        {
            await _repository.InsertAllAsync(entities);
            _unitOfWork.CommitAsync();

            return entities;
        }

        /// <summary>
        /// Deletes and return a task of type bool asynchronously.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns><![CDATA[Task<bool>]]></returns>
        public async Task<bool> DeleteAsync(T entity)
        {
            await _repository.DeleteAsync(entity);
            _unitOfWork.CommitAsync();

            return true;
        }
        /// <summary>
        /// Deletes all asynchronously.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns><![CDATA[Task<bool>]]></returns>
        public async Task<bool> DeleteAllAsync(List<T> entities)
        {
            _repository.DeleteAll(entities);
            _unitOfWork.CommitAsync();

            return true;
        }

        /// <summary>
        /// Update and return a task of type t asynchronously.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns><![CDATA[Task<T>]]></returns>
        public async Task<T> UpdateAsync(T entity)
        {
            _unitOfWork.CommitAsync();
            return entity;
        }
        /// <summary>
        /// Update the all asynchronously.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns><![CDATA[Task<List<T>>]]></returns>
        public async Task<List<T>> UpdateAllAsync(List<T> entities)
        {
            _unitOfWork.CommitAsync();
            return entities;
        }
      

        #endregion


        #endregion



    }
}
