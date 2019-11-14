using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group15.EventManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventApplicationService _eventApplicationService;

        public EventsController(IEventApplicationService eventApplicationService)
        {
            _eventApplicationService = eventApplicationService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllEvents()
        {
            var events = await _eventApplicationService.GetAllEvents();
            return Ok(events);
        }
    }
}