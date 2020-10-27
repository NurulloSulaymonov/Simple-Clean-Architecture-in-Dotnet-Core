using Application.Services.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ExtenstionMethods
{
    public static class ServiceExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(config =>
            {
                config.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IBlogService, BlogService>();
        }
    }
}
