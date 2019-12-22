using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Tickets;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.QueryHandlers
{
    public class TicketQueryHandler : IRequestHandler<AllTicketsQuery, IQueryable<Ticket>>
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketQueryHandler(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public Task<IQueryable<Ticket>> Handle(AllTicketsQuery request, CancellationToken cancellationToken)
        {
            var tickets = _ticketRepository.GetAllTicketsFromUser(request.UserId);
            return Task.FromResult(tickets);
        }
    }
}
