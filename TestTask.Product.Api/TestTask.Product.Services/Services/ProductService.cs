using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using TestTask.Product.Interfaces.Repositories;
using TestTask.Product.Interfaces.Services;
using TestTask.Product.Models.DatabaseModels;

namespace TestTask.Product.Services.Services
{
    /// <summary>
    /// Manages application logic.
    /// </summary>
    public class ProductService : IProductService<ProductData>
    {
        private readonly IGetter<Category> _categoryRepository;
        private readonly IRepository<ProductData> _productRepository;

        /// <summary>
        /// Constructor for ProductService class.
        /// </summary>
        /// <param name="categoryRepository">
        /// Category repository class.
        /// </param>
        /// <param name="productRepository">
        /// Product repository class.
        /// </param>
        public ProductService(IGetter<Category> categoryRepository, IRepository<ProductData> productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        /// <summary>
        /// Creates new product i database.
        /// </summary>
        /// <param name="item">
        /// Input product data.
        /// </param>
        /// <returns></returns>
        public async Task CreateAsync(ProductData item)
        {
            await _productRepository.CreateAsync(item);
        }

        /// <summary>
        /// Gets all products from database.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ProductData>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        /// <summary>
        /// Gets categories from repository.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryRepository.GetAll();
        }
    }
}
