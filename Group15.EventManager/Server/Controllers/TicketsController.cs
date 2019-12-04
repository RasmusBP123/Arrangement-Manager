using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketApplicationService _ticketApplicationService;

        public TicketsController(ITicketApplicationService ticketApplicationService)
        {
            _ticketApplicationService = ticketApplicationService;
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> GetAllTicketsForCart([FromRoute] Guid userId)
        {
            var tickets = await _ticketApplicationService.GetTicketsForCart(userId);
            return Ok(tickets);
        }

        [HttpDelete]
        [Route("delete/{ticketId}")]
        public async Task<IActionResult> DeleteTicket([FromRoute] Guid ticketId)
        {
            await _ticketApplicationService.DeleteTicket(ticketId);
            return NoContent();
        }
    }
}