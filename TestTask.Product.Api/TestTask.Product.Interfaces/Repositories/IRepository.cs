using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Product.Interfaces.Repositories
{
    /// <summary>
    /// Manages work with data.
    /// </summary>
    /// <typeparam name="T">
    /// Input item type.
    /// </typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Creates new item in some storage.
        /// </summary>
        /// <param name="item">
        /// Input data.
        /// </param>
        /// <returns></returns>
        Task CreateAsync(T item);

        /// <summary>
        /// Gets the list of all items 
        /// from storage.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAll();
    }
}
