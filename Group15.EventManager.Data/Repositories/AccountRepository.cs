using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models.Auth;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Group15.EventManager.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateAccount(ApplicationUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            await _userManager.AddToRoleAsync(user, "USER");

            if (user.Email.StartsWith("admin"))
            {
                await _userManager.AddToRoleAsync(user, "ADMIN");
            }

            return result;
        }

        public async Task<ApplicationUser> GetLoggedInUser(ClaimsPrincipal claimsPrincipal)
        {
            string userName = claimsPrincipal.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            var test = await _userManager.GetRolesAsync(user);
     
            return user;
        }

        public Task<ApplicationUser> Login(string email)
        {
            var user = _userManager.FindByEmailAsync(email);
            return user;
        }

        public async Task<IEnumerable<string>> GetRoles(ApplicationUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            return roles;
        }

        public async Task<SignInResult> PasswordSignIn(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, false, false);
            return result;
        }

        public async Task DeleteAccount(ClaimsPrincipal userClaim)
        {
            string userName = userClaim.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            await _userManager.DeleteAsync(user);
        }
    }
}
