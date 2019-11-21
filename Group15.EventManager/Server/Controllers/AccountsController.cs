using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Models.Auth;
using Group15.EventManager.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private static UserModel LoggedOutUser = new UserModel { IsAuthenticated = false };

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        public AccountsController(UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateUser([FromBody] RegisterModel registerModel)
        {
            var newUser = new ApplicationUser() { UserName = registerModel.Email, Email = registerModel.Email };

            var result = await _userManager.CreateAsync(newUser, registerModel.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new RegisterResult() {Successful = false, Errors = errors, });
            }
            _unitOfWork.Commit();

            return Ok(new RegisterResult { Successful = true });
        }
    }
}