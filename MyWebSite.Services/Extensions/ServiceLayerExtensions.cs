using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyWebSite.Service.Services.Abstractions;
using MyWebSite.Service.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
