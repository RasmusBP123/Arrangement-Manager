using System;
using System.Threading.Tasks;
using Group15.EventManager.Application.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        [Route("active")]
        public async Task<IActionResult> GetActiveEvents()
        {
            var events = await _eventApplicationService.GetActiveEvents();
            if (events == null) return BadRequest();
            return Ok(events);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllEvents()
        {
            var events = await _eventApplicationService.GetAllEvents();
            if (events == null) return BadRequest();
            return Ok(events);
        }

        [HttpGet]
        [Route("region/{regionId}")]
        public async Task<IActionResult> GetAllEventsByRegion(Guid regionId)
        {
            var events = await _eventApplicationService.GetAllEventsByRegion(regionId);
            if (events == null) return BadRequest();
            return Ok(events);
        }

        [HttpGet]
        [Route("region/{regionId}/city/{cityId}")]
        public async Task<IActionResult> GetAllEventsByRegionAndCity(Guid regionId, Guid cityId)
        {
            var events = await _eventApplicationService.GetAllEventsByRegionAndCity(regionId, cityId);
            if (events == null) return BadRequest();
            return Ok(events);
        }

        [HttpGet]
        [Route("{eventId}")]
        public async Task<IActionResult> GetSingleEvent([FromRoute] Guid eventId)
        {
            var _event = await _eventApplicationService.GetSingleEvent(eventId);
            if (_event == null) return BadRequest();
            return Ok(_event);
        }

        [HttpPost]
        [Route("{eventId}/user/signup")]
        public async Task<IActionResult> SignUserUpForEvent([FromRoute]Guid eventId)
        {
            return Ok();
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
        public async Task<IActionResult> UpdateEvent(Guid eventId, [FromBody] UpdateEventViewModel eventViewModel)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(422, eventViewModel);
            }

            await _eventApplicationService.UpdateEvent(eventId, eventViewModel);
            return Ok();
        }

        [HttpDelete] 
        [Route("{eventId}/delete")]
        [Authorize]
        public async Task<IActionResult> DeleteEvent([FromRoute] Guid eventId)
        {
            await _eventApplicationService.DeleteEvent(eventId);
            return NotFound();
        }
    }
}