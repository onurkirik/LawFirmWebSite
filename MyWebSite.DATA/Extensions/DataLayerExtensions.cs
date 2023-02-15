using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyWebSite.DATA.Context;
using MyWebSite.DATA.Repositories.Abstractions;
using MyWebSite.DATA.Repositories.Concretes;
using MyWebSite.DATA.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DATA.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(config.GetConnectionString("ConnectionString")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
