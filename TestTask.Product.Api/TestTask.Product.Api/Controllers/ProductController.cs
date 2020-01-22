using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestTask.Product.Interfaces.Services;
using TestTask.Product.Models.DatabaseModels;

namespace TestTask.Product.Api.Controllers
{
    /// <summary>
    /// Manages api methods work.
    /// </summary>
    // https://localhost:44363/
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService<ProductData> _productService;
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor for ProductController class.
        /// </summary>
        /// <param name="productService"></param>
        public ProductController(IProductService<ProductData> productService, ILogger<ProductController> logger)
        {
            _logger = logger;
            _productService = productService;
        }

        /// <summary>
        /// Creates new product.
        /// </summary>
        /// <param name="product">
        /// Input product data.
        /// </param>
        /// <returns></returns>
        // POST: https://localhost:44363/api/Product/Create
        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync([FromBody] ProductData product)
        {
            try
            {
                await _productService.CreateAsync(product);
                return Ok();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.ToString());
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Gets the list of products.
        /// </summary>
        /// <returns></returns>
        // GET: https://localhost:44363/api/Product/
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                IEnumerable<ProductData> products = await _productService.GetAll();
                return Ok(products);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.ToString());
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Gets all product categories.
        /// </summary>
        /// <returns></returns>
        [HttpGet("Categories")]
        public async Task<IActionResult> GetCategoriesAsync()
        {
            try
            {
                IEnumerable<string> categories = await _productService.GetCategories();
                return Ok(categories);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.ToString());
                return BadRequest(exception.Message);
            }
        }
    }
}