using Group15.EventManager.Application.Interfaces;
using Group15.EventManager.Application.Services;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.Services;
using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.Repositories;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.CommandHandlers;
using Group15.EventManager.Domain.Commands.Customers;
using Group15.EventManager.Domain.Commands.Events;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Events;
using Group15.EventManager.Domain.Queries.Events.Filters;
using Group15.EventManager.Domain.Queries.Regions;
using Group15.EventManager.Domain.QueryHandlers;
using Group15.EventManager.Identity.Data;
using Group15.EventManager.Identity.Interfaces;
using Group15.EventManager.Identity.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Group15.EventManager.Bootstrapper
{
    public static class Bootstrapper
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //DB
            services.AddScoped<SqlContext>();
            services.AddScoped<IdentityContext>();

            services.RegisterApplicationServices();
            services.RegisterRepositories();
            services.RegisterCommands();
            services.RegisterQueries();

            //Unit of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountApplicationService, AccountApplicationService>();
            services.AddScoped<IEventApplicationService, EventApplicationService>();
            services.AddScoped<IFoodApplicationService, FoodApplicationService>();
            services.AddScoped<IRegionApplicationService, RegionApplicationService>();
            services.AddScoped<ICustomerApplicationService, CustomerApplicationService>();
        }

        public static void RegisterCommands(this IServiceCollection services)
        {
            //Events
            services.AddScoped<IRequestHandler<CreateEventCommand, bool>, EventCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateEventCommand, bool>, EventCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteEventCommand, bool>, EventCommandHandler>();
            //Customers
            services.AddScoped<IRequestHandler<SignCustomerUpForEventCommand, bool>, CustomerCommandHandler>();
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
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
