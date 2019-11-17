using Blazor.Fluxor;
using Blazor.Fluxor.ReduxDevTools;
using Blazor.Fluxor.Routing;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Group15.EventManager.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
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
