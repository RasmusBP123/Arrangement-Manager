﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private static UserModel LoggedOutUser = new UserModel { IsAuthenticated = false };
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

        [HttpPost]
        [Route("{userId}/delete")]
        public async Task<IActionResult> DeleteAccount([FromRoute] Guid userId)
        {
            if (userId == Guid.Empty) return BadRequest();
            await _accountApplicationService.DeleteAccount(userId);

            return NotFound();
        }
    }
}