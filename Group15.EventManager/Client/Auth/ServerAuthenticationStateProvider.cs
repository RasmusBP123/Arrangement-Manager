using Group15.EventManager.Shared.Customers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Auth
{
    public class ServerAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;

        public ServerAuthenticationStateProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var userInfo = await _httpClient.GetJsonAsync<GetCustomerViewModel>("api");
            var claim = new Claim(ClaimTypes.Name, "Fakey");
            var identity = new ClaimsIdentity(new[] { claim }, "serverauth");
            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
    }
}
