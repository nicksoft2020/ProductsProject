using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Product.Interfaces.Repositories;
using TestTask.Product.Models.Configuration;
using TestTask.Product.Models.DatabaseModels;
using TestTask.Product.Repositories.SqlQueries;

namespace TestTask.Product.Repositories.Repositories
{

    public class SqlServerProductRepository : IRepository<ProductData>
    {
        private readonly string _connectionString;

        /// <summary>
        /// Constructor for SqlServerProductRepository class.
        /// </summary>
        /// <param name="options">
        /// Input configuration settings.
        /// </param>
        public SqlServerProductRepository(IOptions<ConnectionStrings> options)
        {
            _connectionString = options.Value.localDbConnection;
        }

        /// <summary>
        /// Creates new product in database.
        /// </summary>
        /// <param name="item">
        /// Input product data.
        /// </param>
        /// <returns></returns>
        public async Task CreateAsync(ProductData item)
        {
            using(IDbConnection db = new SqlConnection(_connectionString))
            {
                await db.ExecuteAsync(MSSQLQueries.CreateProduct, item);
            }
        }

        /// <summary>
        /// Gets all products from database.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ProductData>> GetAll()
        {
            using(var db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<ProductData>(MSSQLQueries.GetAllProducts);
            }
        }
    }
}
