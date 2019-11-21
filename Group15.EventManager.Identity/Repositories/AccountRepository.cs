using Group15.EventManager.Domain.Models.Auth;
using Group15.EventManager.Identity.Data;
using Group15.EventManager.Identity.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Identity.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IdentityContext _identityContext;

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IdentityContext identityContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _identityContext = identityContext;
        }

        public async Task<IdentityResult> CreateAccount(ApplicationUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            return result;
        }

        public async Task DeleteAccount(Guid userId)
        {
            string id = userId.ToString();
            var user = _identityContext.Set<ApplicationUser>().FirstOrDefault(appUser => appUser.Id == id);
            await _userManager.DeleteAsync(user);
        }

        public async Task<SignInResult> PasswordSignIn(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, false, false);
            return result;
        }
    }
}
