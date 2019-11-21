using Group15.EventManager.Shared.Auth;
using System;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Auth.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
        Task DeleteUser();
    }
}
