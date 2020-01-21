using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using TestTask.Product.Interfaces.Repositories;
using TestTask.Product.Models.Configuration;
using TestTask.Product.Models.DatabaseModels;
using TestTask.Product.Repositories.SqlQueries;

namespace TestTask.Product.Repositories.Repositories
{
    /// <summary>
    /// Manages work with categories in storage.
    /// </summary>
    public class SqlServerCategoryRepository : IGetter<Category>
    {
        private readonly string _connectionString;

        /// <summary>
        /// Constructor for SqlServerCategoryRepository class.
        /// </summary>
        /// <param name="options">
        /// Input configuration settings.
        /// </param>
        public SqlServerCategoryRepository(IOptions<ConnectionStrings> options)
        {
            _connectionString = options.Value.localDbConnection;
        }
        
        /// <summary>
        /// Gets all categories from database.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Category>> GetAll()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                return await db.QueryAsync<Category>(MSSQLQueries.GetAllCategories);
            }
        }
    }
}
