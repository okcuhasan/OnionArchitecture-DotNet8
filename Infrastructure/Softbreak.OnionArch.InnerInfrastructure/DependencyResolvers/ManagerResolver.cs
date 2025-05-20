using Microsoft.Extensions.DependencyInjection;
using Softbreak.OnionArch.APPLICATION.Managers;
using Softbreak.OnionArch.InnerInfrastructure.ManagerConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.InnerInfrastructure.DependencyResolvers
{
    public static class ManagerResolver
    {
        public static IServiceCollection AddManagerService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManager<,>), typeof(BaseManager<,>));
            services.AddScoped<IAppRoleManager, AppRoleManager>();
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppUserProfileManager, AppUserProfileManager>();
            services.AddScoped<IAppUserRoleManager, AppUserRoleManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IOrderDetailManager, OrderDetailManager>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<IProductManager, ProductManager>();
            return services;
        }
    }
}
