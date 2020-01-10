using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountApplicationService _accountApplicationService;

        public AccountsController(IAccountApplicationService accountApplicationService)
        {
            _accountApplicationService = accountApplicationService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateAccount([FromBody] RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _accountApplicationService.CreateAccount(registerModel);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new RegisterResult() { Successful = false, Errors = errors });
            }
            return Created("api/accounts/create", new RegisterResult() { Successful = true });
        }

        [HttpPost]
        [Route("update/password")]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdateAccountPasswordModel user)
        {
            var result = await _accountApplicationService.UpdatePassword(user);
            if (result.Succeeded)
            {
                return Ok(true);
            }

            return BadRequest(result.Errors);
        }
 
        [HttpGet]
        [Route("user")]
        public async Task<IActionResult> GetUser()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return NoContent();
            }
            var claims = HttpContext.User;
            var user = await _accountApplicationService.GetLoggedInUser(claims);
            return Ok(user);
        }

        //Used for validating if user is logged in or not, so you cannot register or log in if already logged in
        [HttpGet]
        [Route("valid")]
        public IActionResult IsUserAuthenticated()
        {
            var isAuthenticated = HttpContext.User.Identity.IsAuthenticated;
            return Ok(isAuthenticated);
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteAccount()
        {
            var user = HttpContext.User;
            await _accountApplicationService.DeleteAccount(user);
            return NoContent();
        }
    }
}