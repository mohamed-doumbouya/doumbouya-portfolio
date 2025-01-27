using Microsoft.EntityFrameworkCore;
using MyPortfolio.Domain.Interfaces.Repositories.Generics;
using MyPortfolio.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Infrastructure.Repositories.Generics
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        #region Fields
        private readonly ApplicationDbContext _dbContext;
        protected DbSet<TEntity> _entities {  get; }
        #endregion Fields

        #region Constructor
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _entities = _dbContext.Set<TEntity>();
        }
        #endregion Constructor

        #region IGenericRepository implementation
        /// <summary>
        /// Insert new entity in the source
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task CreateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
                

            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Return true if any element in the source pass test
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> ExistAsync(int id) => await _dbContext.Set<TEntity>().AnyAsync(entity => EF.Property<int>(entity, "Id").Equals(id));

        /// <summary>
        /// Return all entities from the source
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<TEntity>> GetAll() => await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();

        /// <summary>
        /// Return the matching entity if found or return null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<TEntity?> GetById(int id) => await _dbContext.Set<TEntity>().FindAsync(id);

        /// <summary>
        /// Return the matching entity if found or return null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<TEntity?> GetById(string id) => await _dbContext.Set<TEntity>().FindAsync(id);

        /// <summary>
        /// Remove the given entity from the source
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task RemoveAsync(TEntity entity)
        {
            if(entity != null)
            {
                if(_dbContext.Entry(entity).State == EntityState.Detached)
                {
                    _dbContext.Set<TEntity>().Attach(entity);
                }

               _dbContext.Set<TEntity>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Update the given entity if not null
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<bool> UpdateAsync(TEntity entity)
        {
            var changes = 0;
            if(entity != null)
            {
                if(_dbContext.Entry(entity).State == EntityState.Detached)
                {
                    _dbContext.Set<TEntity>().Attach(entity);
                }

                _dbContext.Entry(entity).State = EntityState.Modified;
                changes = await _dbContext.SaveChangesAsync();
            }

            return changes > 0;
        }
        #endregion IGenericRepository Implementation
    }
}
