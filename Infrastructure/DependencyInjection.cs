using Domain.Entities;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, string connectionString )
        {
            services.AddDbContext<ApplicationDbContext>( options => options.UseSqlServer(connectionString));
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
