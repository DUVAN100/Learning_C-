using Application.Interface;
using Application.Main;
using Domain.Core;
using Domain.Interfase;
using Infraextructure.Repository;
using IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace PruebaFIX.Modules.Injection
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {              
            services.AddSingleton<IConfiguration>(configuration);
            services.AddScoped<IRecuestApplication, RecuestApplication>();
            services.AddScoped<IRecuestDomain, RecuestDomain>();
            services.AddScoped<IRecuestRepository, RecuestRepository>();
            services.AddScoped<IUserApplication, UserApplication>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserDomain, UserDomain>();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Connection")));
            return services;
        }
    }
}
