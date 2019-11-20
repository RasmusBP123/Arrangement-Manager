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
using Group15.EventManager.Domain.Queries.Events.Filters;
using Group15.EventManager.Domain.Queries.Regions;
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
            services.RegisterCommands();
            services.RegisterQueries();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IEventApplicationService, EventApplicationService>();
            services.AddScoped<IFoodApplicationService, FoodApplicationService>();
            services.AddScoped<IRegionApplicationService, RegionApplicationService>();
        }

        public static void RegisterCommands(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CreateEventCommand, bool>, EventCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateEventCommand, bool>, EventCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteEventCommand, bool>, EventCommandHandler>();
        }

        public static void RegisterQueries(this IServiceCollection services)
        {
            //Events
            services.AddScoped<IRequestHandler<AllActiveEventsQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<AllEventsQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<AllEventsByRegionQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<AllEventsByRegionAndCityQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<SingleEventQuery, Event>, EventQueryHandler>();
            //Regions
            services.AddScoped<IRequestHandler<AllRegionsQuery, IQueryable<Region>>, RegionQueryHandler>();
            services.AddScoped<IRequestHandler<SingleRegionQuery, Region>,RegionQueryHandler>();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
        }
    }
}
