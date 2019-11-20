using Blazor.Fluxor;
using Blazor.Fluxor.ReduxDevTools;
using Blazor.Fluxor.Routing;
using Group15.EventManager.Client.Store.Events;
using Group15.EventManager.Client.Store.Regions;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Group15.EventManager.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<RegionStore>();
            services.AddScoped<EventStore>();
            services.AddFluxor(options => options
                .UseDependencyInjection(typeof(Startup).Assembly)
                .AddMiddleware<ReduxDevToolsMiddleware>()
                .AddMiddleware<RoutingMiddleware>()
            );
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
