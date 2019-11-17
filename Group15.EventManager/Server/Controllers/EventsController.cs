using System;
using System.Threading.Tasks;
using Group15.EventManager.Application.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
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
        public IActionResult GetActiveEvents()
        {
            var events = _eventApplicationService.GetActiveEvents();
            if (events == null) return BadRequest();
            return Ok(events);
        }

        [HttpGet("all")]
        public IActionResult GetAllEvents()
        {
            var events = _eventApplicationService.GetAllEvents();
            if (events == null) return BadRequest();
            return Ok(events);
        }

        [HttpGet]
        [Route("{eventId}")]
        public IActionResult GetSingleEvent([FromRoute] Guid eventId)
        {
            var _event = _eventApplicationService.GetSingleEvent(eventId);
            if (_event == null) return BadRequest();
            return Ok(_event);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateEvent([FromBody]CreateEventViewModel eventViewModel)
        {
            if (!ModelState.IsValid)
                return StatusCode(422, eventViewModel);

            await _eventApplicationService.CreateEvent(eventViewModel);
            return StatusCode(201, eventViewModel);
        }

        [HttpPost]
        [Route("{eventId}/update")]
        public IActionResult UpdateEvent(Guid eventId, UpdateEventViewModel eventViewModel)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(422, eventViewModel);
            }
            _eventApplicationService.UpdateEvent(eventId, eventViewModel);
            return Ok();
        }
    }
}