using Blazor.Fluxor;
using Blazor.Fluxor.ReduxDevTools;
using Blazor.Fluxor.Routing;
using Blazored.LocalStorage;
using Blazored.Modal;
using Group15.EventManager.Client.Auth;
using Group15.EventManager.Client.Auth.Services;
using Group15.EventManager.Client.Store.Address_;
using Group15.EventManager.Client.Store.Attendances;
using Group15.EventManager.Client.Store.Auth;
using Group15.EventManager.Client.Store.Cities;
using Group15.EventManager.Client.Store.Employees;
using Group15.EventManager.Client.Store.Events;
using Group15.EventManager.Client.Store.Foods;
using Group15.EventManager.Client.Store.Regions;
using Group15.EventManager.Client.Store.Stores;
using Group15.EventManager.Client.Store.Themes;
using Group15.EventManager.Client.Store.Tickets;
using Group15.EventManager.Client.Store.Users;
using Group15.EventManager.Shared.Auth.Policies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Mail;

namespace Group15.EventManager.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //State
            services.AddScoped<AddressStore>();
            services.AddScoped<AttendanceStore>();
            services.AddScoped<RegionStore>();
            services.AddScoped<EventStore>();
            services.AddScoped<AuthStore>();
            services.AddScoped<EmployeeStore>();
            services.AddScoped<FoodStore>();
            services.AddScoped<CityStore>();
            services.AddScoped<UserStore>();
            services.AddScoped<StoreStore>();
            services.AddScoped<TicketStore>();

            //Themes
            services.AddSingleton<ThemeStore>();
            //Fluxor
            services.AddFluxor(options => options
                .UseDependencyInjection(typeof(Startup).Assembly)
                .AddMiddleware<ReduxDevToolsMiddleware>()
                .AddMiddleware<RoutingMiddleware>()
            );

            //Blazored
            services.AddBlazoredModal();
            services.AddBlazoredLocalStorage();

            //Auth services 
            services.AddAuthorizationCore(config =>
            {
                config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
                config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
            });
            services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
            services.AddScoped<IAuthService, AuthService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
