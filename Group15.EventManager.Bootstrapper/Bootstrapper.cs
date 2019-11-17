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
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Events;
using Group15.EventManager.Domain.QueryHandlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

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
            services.RegisterQueries();
        }

        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IEventApplicationService, EventApplicationService>();
            services.AddScoped<IFoodApplicationService, FoodApplicationService>();
        }

        public static void RegisterCommands(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CreateEventCommand, bool>, EventCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateEventCommand, bool>, EventCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteEventCommand, bool>, EventCommandHandler>();
        }

        public static void RegisterQueries(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<ActiveEventsQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<AllEventsQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<SingleEventQuery, Event>, EventQueryHandler>();

        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
        }
    }
}
