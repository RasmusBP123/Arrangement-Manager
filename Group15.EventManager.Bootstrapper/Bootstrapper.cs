using Group15.EventManager.Application.Interfaces;
using Group15.EventManager.Application.Services;
using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Group15.EventManager.Bootstrapper
{
    public static class Bootstrapper
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<SqlContext>();

            services.RegisterApplicationServices();
            services.RegisterRepositories();
        }

        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IEventApplicationService, EventApplicationService>();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
        }
    }
}
