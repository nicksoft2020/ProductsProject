using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Product.Interfaces.Repositories
{
    /// <summary>
    /// Gets items from storage.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGetter<T>
    {
        /// <summary>
        /// Gets items from storage.
        /// </summary>
        Task<IEnumerable<T>> GetAll();
    }
}
