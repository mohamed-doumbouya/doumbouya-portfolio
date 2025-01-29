using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Domain.Interfaces.Repositories.Generics
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Insert new entity in the source
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        Task CreateAsync(TEntity entity);

        /// <summary>
        /// Remove the given entity from the source
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task RemoveAsync(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);

        /// <summary>
        /// Return true if any element in the source pass test
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> ExistAsync(int id);

        /// <summary>
        /// Return the matching entity if found or return null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity?> GetByIdAsync(int id);

        /// <summary>
        /// Return the matching entity if found or return null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity?> GetByIdAsync(string id);

        /// <summary>
        /// Return all entities from the source
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
