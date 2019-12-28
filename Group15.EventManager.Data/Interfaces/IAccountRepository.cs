using Group15.EventManager.Domain.Models.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Group15.EventManager.Data.Interfaces
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateAccount(ApplicationUser user, string password);
        Task<SignInResult> PasswordSignIn(string email, string password);
        Task<ApplicationUser> GetLoggedInUser(ClaimsPrincipal claimsPrincipal);
        Task<ApplicationUser> Login(string email);
        Task<IEnumerable<string>> GetRoles(ApplicationUser user);
        Task<IdentityResult> UpdatePassword(Guid userId, string currentPassword, string newPassword);
        Task DeleteAccount(ClaimsPrincipal userClaim);
    }
}
