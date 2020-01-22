using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestTask.Product.Models.DatabaseModels;

namespace TestTask.Product.Interfaces.Services
{
    /// <summary>
    /// Manages application logic.
    /// </summary>
    public interface IProductService<T>
    {
        /// <summary>
        /// Creates new item.
        /// </summary>
        /// <param name="item">
        /// Input item data.
        /// </param>
        /// <returns></returns>
        Task CreateAsync(T item);

        /// <summary>
        /// Gets all elements from repositories.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAll();

        /// <summary>
        /// Gets all categories from repository.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<string>> GetCategories();
    }
}
