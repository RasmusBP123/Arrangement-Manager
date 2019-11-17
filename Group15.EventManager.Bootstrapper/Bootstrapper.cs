using Group15.EventManager.Application.Interfaces;
using Group15.EventManager.Application.Services;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.Services;
using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.Repositories;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.CommandHandlers;
using Group15.EventManager.Domain.Commands.Events;
using MediatR;
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
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.RegisterCommands();
        }

        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IEventApplicationService, EventApplicationService>();
            services.AddScoped<IFoodApplicationService, FoodApplicationService>();
        }

        public static void RegisterCommands(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CreateEventCommand, bool>, EventCommandHandler>();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
        }
    }
}
