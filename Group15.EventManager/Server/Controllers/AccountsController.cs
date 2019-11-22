using System.Linq;
using System.Threading.Tasks;
using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
            return Ok(new RegisterResult() { Successful = true });
        }

        [HttpGet]
        [Route("user")]
        [Authorize]
        public async Task<IActionResult> GetUser()
        {
            var claims = HttpContext.User;
            var user = await _accountApplicationService.GetLoggedInUser(claims);
            return Ok(user);
        }

        [HttpPost]
        [Route("delete")]
        [Authorize]
        public async Task<IActionResult> DeleteAccount()
        {
            var user = HttpContext.User;
            if (user == null) return BadRequest();

            await _accountApplicationService.DeleteAccount(user);
            return NotFound();
        }
    }
}