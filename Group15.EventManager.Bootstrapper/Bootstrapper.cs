using FluentValidation;
using Group15.EventManager.Application.Interfaces;
using Group15.EventManager.Application.Services;
using Group15.EventManager.Application.Validation.Events;
using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.Services;
using Group15.EventManager.ApplicationLayer.Validation.Accounts;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.Repositories;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.CommandHandlers;
using Group15.EventManager.Domain.Commands.Events;
using Group15.EventManager.Domain.Commands.Store;
using Group15.EventManager.Domain.Commands.Tickets;
using Group15.EventManager.Domain.Commands.Users;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using Group15.EventManager.Domain.Queries.Cities;
using Group15.EventManager.Domain.Queries.Events;
using Group15.EventManager.Domain.Queries.Events.Filters;
using Group15.EventManager.Domain.Queries.Regions;
using Group15.EventManager.Domain.Queries.Stores;
using Group15.EventManager.Domain.Queries.Tickets;
using Group15.EventManager.Domain.Queries.Users;
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
            //DB
            services.AddScoped<SqlContext>();

            services.RegisterApplicationServices();
            services.RegisterRepositories();
            services.RegisterCommands();
            services.RegisterQueries();
            services.RegisterValidators();

            //Unit of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountApplicationService, AccountApplicationService>();
            services.AddScoped<ICityApplicationService, CityApplicationService>();
            services.AddScoped<IEventApplicationService, EventApplicationService>();
            services.AddScoped<IRegionApplicationService, RegionApplicationService>();
            services.AddScoped<IUserApplicationService, UserApplicationService>();
            services.AddScoped<IStoreApplicationService, StoreApplicationService>();
            services.AddScoped<ITicketApplicationService, TicketApplicationService>();
        }

        public static void RegisterCommands(this IServiceCollection services)
        {
            //Events
            services.AddScoped<IRequestHandler<CreateEventCommand, bool>, EventCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateEventCommand, bool>, EventCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteEventCommand, bool>, EventCommandHandler>();
            //Users
            services.AddScoped<IRequestHandler<AddUserToEventCommand, bool>, UserCommandHandler>();
            services.AddScoped<IRequestHandler<CancelEventForUserCommand, bool>, UserCommandHandler>();
            //Stores
            services.AddScoped<IRequestHandler<CreateStoreCommand, bool>, StoreCommandHandler>();
            //Tickets
            services.AddScoped<IRequestHandler<DeleteTicketCommand, bool>, TicketCommandHandler>();
        }

        public static void RegisterQueries(this IServiceCollection services)
        {
            //Events
            services.AddScoped<IRequestHandler<AllActiveEventsQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<AllEventsQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<AllEventsByRegionQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<AllEventsByRegionAndCityQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<AllEventsForUserQuery, IQueryable<Event>>, EventQueryHandler>();
            services.AddScoped<IRequestHandler<SingleEventQuery, Event>, EventQueryHandler>();
            //Regions
            services.AddScoped<IRequestHandler<AllRegionsQuery, IQueryable<Region>>, RegionQueryHandler>();
            services.AddScoped<IRequestHandler<SingleRegionQuery, Region>,RegionQueryHandler>();
            //Cities
            services.AddScoped<IRequestHandler<SingleCityQuery, City>, CityQueryHandler>();
            //Users
            services.AddScoped<IRequestHandler<AllUsersFromEventQuery, IQueryable<ApplicationUser>>, UserQueryHandler>();
            services.AddScoped<IRequestHandler<SingleUserQuery, ApplicationUser>, UserQueryHandler>();
            //Stores
            services.AddScoped<IRequestHandler<AllStroresQuery, IQueryable<Store>>, StoreQueryHandler>();
            services.AddScoped<IRequestHandler<SingleStoreQuery, Store>, StoreQueryHandler>();
            //Tickets
            services.AddScoped<IRequestHandler<AllTicketsQuery, IQueryable<Ticket>>, TicketQueryHandler>();
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
        }

        public static void RegisterValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<CreateEventViewModel>, CreateEventValidator>();
            services.AddTransient<IValidator<RegisterModel>, RegisterValidator>();
        }
    }
}
