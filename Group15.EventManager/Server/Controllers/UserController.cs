using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserApplicationService _userApplicationService;

        public UserController(IUserApplicationService userApplicationService)
        {
            _userApplicationService = userApplicationService;
        }

        [HttpGet]
        [Route("{eventId}/users")]
        public async Task<IActionResult> GetAllUsersFromEvent(Guid eventId)
        {
            var users = await _userApplicationService.GetUsersFromEvent(eventId);
            return Ok(users);
        }

        [HttpPost]
        [Route("{eventId}/book/event")]
        public async Task<IActionResult> AddUserToEvent([FromBody] AddUserToEventViewModel userEventViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _userApplicationService.AddUserToEvent(userEventViewModel);
            return Created("", userEventViewModel);
        }

        [HttpDelete]
        [Route("{userId}/delete/{eventId}/event")]
        public async Task<IActionResult> CancelEventFromUser(Guid userId, Guid eventId)
        {
            await _userApplicationService.CancelEventFromUser(userId, eventId);
            return NoContent();
        }
    }
}