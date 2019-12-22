using Group15.EventManager.Application.ViewModels.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface IAccountApplicationService : IDisposable
    {
        Task<IdentityResult> CreateAccount(RegisterModel registerModel);
        Task<SignInResult> PasswordSignIn(LoginModel loginModel);
        Task<UserModel> GetLoggedInUser(ClaimsPrincipal claimsPrincipal);
        Task<UserModel> Login(string email);
        Task<IEnumerable<string>> GetRoles(UserModel user);
        Task DeleteAccount(ClaimsPrincipal userClaim);
    }
}
