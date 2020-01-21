using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using TestTask.Product.Interfaces.Repositories;
using TestTask.Product.Models.Configuration;
using TestTask.Product.Models.DatabaseModels;
using TestTask.Product.Repositories.Repositories;

namespace TestTask.Product.Repositories.Configuration
{
    public static class RepositoriesConfig
    {
        /// <summary>
        /// Adds repository configuration settings.
        /// </summary>
        /// <param name="services">
        /// Uses to add settings.
        /// </param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            services.AddTransient<IGetter<Category>, SqlServerCategoryRepository>();
            services.AddTransient<IRepository<ProductData>, SqlServerProductRepository>();

            return services;
        }
    }
}
