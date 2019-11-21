using Group15.EventManager.Domain.Models.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Group15.EventManager.Identity.Interfaces
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateAccount(ApplicationUser user, string password);
        Task<SignInResult> PasswordSignIn(string email, string password);
        Task<ApplicationUser> GetLoggedInUser(ClaimsPrincipal claimsPrincipal);
        Task DeleteAccount(ClaimsPrincipal userClaim);
    }
}
