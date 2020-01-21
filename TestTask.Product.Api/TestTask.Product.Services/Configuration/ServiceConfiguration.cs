using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TestTask.Product.Interfaces.Services;
using TestTask.Product.Models.DatabaseModels;
using TestTask.Product.Services.Services;

namespace TestTask.Product.Services.Configuration
{
    public static class ServiceConfiguration
    {
        /// <summary>
        /// Adds repository configuration settings.
        /// </summary>
        /// <param name="services">
        /// Uses to add settings.
        /// </param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService<ProductData>, ProductService>();
            return services;
        }
    }
}
