using Blazor.Fluxor;
using Blazor.Fluxor.ReduxDevTools;
using Blazor.Fluxor.Routing;
using Blazored.LocalStorage;
using Group15.EventManager.Client.Auth;
using Group15.EventManager.Client.Auth.Services;
using Group15.EventManager.Client.Store.Auth;
using Group15.EventManager.Client.Store.Events;
using Group15.EventManager.Client.Store.Regions;
using Group15.EventManager.Client.Store.Users;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Group15.EventManager.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //State
            services.AddScoped<RegionStore>();
            services.AddScoped<EventStore>();
            services.AddScoped<AuthStore>();
            services.AddScoped<UserStore>();
            //Fluxor
            services.AddFluxor(options => options
                .UseDependencyInjection(typeof(Startup).Assembly)
                .AddMiddleware<ReduxDevToolsMiddleware>()
                .AddMiddleware<RoutingMiddleware>()
            );

            //Auth services 
            services.AddBlazoredLocalStorage();
            services.AddAuthorizationCore();
            services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
            services.AddScoped<IAuthService, AuthService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
