using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Tickets;
using Group15.EventManager.Domain.Commands.Tickets;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using Group15.EventManager.Domain.Queries.Tickets;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class TicketApplicationService : Service, ITicketApplicationService
    {
        public TicketApplicationService(IMapper mapper, IMediator mediator) : base(mapper, mediator)
        {
        }

        public async Task<IEnumerable<GetTicketForCartViewModel>> GetTicketsForCart(Guid userId)
        {
            var tickets = await _mediator.Send(new AllTicketsQuery(userId));
            var ticketViewModels = _mapper.Map<IEnumerable<GetTicketForCartViewModel>>(tickets);
            return ticketViewModels;
        }
        public async Task DeleteTicket(Guid ticketId)
        {
            await _mediator.Send(new DeleteTicketCommand(ticketId));
        }

        public async Task UpdateTickets(UpdateTicketsViewModel tickets)
        {
            var user = _mapper.Map<ApplicationUser>(tickets.User);
            var events = _mapper.Map<IEnumerable<Event>>(tickets.Events);
            await _mediator.Send(new UpdateTicketsCommand(user, events));
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
