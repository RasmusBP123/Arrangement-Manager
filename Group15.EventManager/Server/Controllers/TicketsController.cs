using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Tickets;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateTickets([FromBody] UpdateTicketsViewModel tickets)
        {
            await _ticketApplicationService.UpdateTickets(tickets);
            return Ok();
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