using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// The repository.
    /// </summary>
    /// <typeparam name="T"/>
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// The db context.
        /// </summary>
        private readonly MyDbContext _dbContext;
        /// <summary>
        /// The db set.
        /// </summary>
        private readonly DbSet<T> _dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        /// <param name="ctx">The ctx.</param>
        public Repository(MyDbContext ctx)
        {
            _dbContext = ctx;
            _dbSet = _dbContext.Set<T>();
        }

        #region Syncorouns

        #region Read
        /// <summary>
        /// Get the all.
        /// </summary>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        /// <summary>
        /// Get by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>A T</returns>
        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }
        /// <summary>
        /// Find the by.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="includes">The includes.</param>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = _dbSet.AsQueryable().Where(predicate);

            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToList();
        }

        #endregion

        #region Write

        public T Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity) + " ne doit pas etre null");

            _dbSet.Add(entity);
            return entity;
        }

        /// <summary>
        /// Inserts the all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <exception cref="ArgumentException"></exception>
        public void InsertAll(List<T> entities)
        {
            if (entities == null || !entities.Any())
                throw new ArgumentException(nameof(entities) + " ne doit pas etres ni null ni une liste vide");

            _dbSet.AddRange(entities);
        }

        public T Update(T entity)
        {
            return entity;
        }

        /// <summary>
        /// Update the all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>A T</returns>
        public T UpdateAll(T entities)
        {
            return entities;
        }


        public bool Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity) + " ne doit pas etre null");

            _dbSet.Remove(entity);

            return true;
        }

        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>A bool</returns>
        public bool DeleteAll(List<T> entities)
        {
            if (entities != null && entities.Any())
                _dbSet.RemoveRange(entities);

            return true;
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
            return await _dbSet.FindAsync(id);
        }

        /// <summary>
        /// Get the all asynchronously.
        /// </summary>
        /// <returns><![CDATA[Task<List<T>>]]></returns>
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        /// <summary>
        /// Find by aync.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="includes">The includes.</param>
        /// <returns><![CDATA[Task<List<T>>]]></returns>
        public async Task<List<T>> FindByAync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = _dbSet.AsQueryable().Where(predicate);

            return  await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToListAsync();  
        }
        #endregion

        #region Write

        /// <summary>
        /// Inserts and return a task of type t asynchronously.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns><![CDATA[Task<T>]]></returns>
        public async Task<T> InsertAsync(T entity)
        {
            if (entity == null) 
                throw new ArgumentNullException(nameof(entity) + " ne doit pas etre null");

            await _dbSet.AddAsync(entity);

            return entity;
        }

        /// <summary>
        /// Inserts the all asynchronously.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns><![CDATA[Task<List<T>>]]></returns>
        public async Task<List<T>> InsertAllAsync(List<T> entities)
        {
            if (entities == null|| !entities.Any())
                throw new ArgumentNullException(nameof(entities) + " ne doit pas etre ni null ni vide");

            await _dbSet.AddRangeAsync(entities);

            return entities;
        }

        /// <summary>
        /// Deletes and return a task of type bool asynchronously.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns><![CDATA[Task<bool>]]></returns>
        public async Task<bool> DeleteAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity) + " ne doit pas etre null");

            if (await _dbSet.ContainsAsync(entity))
                _dbSet.Remove(entity);

            return true;
        }

        #endregion

        #endregion

    }
}
