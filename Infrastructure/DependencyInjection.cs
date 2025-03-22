using Domain.Entities;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, string connectionString )
        {
            services.AddDbContext<ApplicationDbContext>( options => options.UseSqlServer(connectionString));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddIdentityCore<UserAuthentication>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<SignInManager<UserAuthentication>>();
            services.AddScoped<UserManager<UserAuthentication>>();
            return services;
        }
    }
}
