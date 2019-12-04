using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Tickets;
using Group15.EventManager.Domain.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.CommandHandlers
{
    public class TicketCommandHandler : Handler, IRequestHandler<DeleteTicketCommand, bool>
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketCommandHandler(IUnitOfWork unitOfWork, ITicketRepository ticketRepository) : base(unitOfWork)
        {
            _ticketRepository = ticketRepository;
        }

        public Task<bool> Handle(DeleteTicketCommand request, CancellationToken cancellationToken)
        {
            _ticketRepository.Remove(request.TicketId);
            _unitOfWork.Commit();
            return Task.FromResult(true);
        }
    }
}
