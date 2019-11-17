using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Handlers;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.QueryHandlers
{
    public class EventQueryHandler : Handler,
                                    IRequestHandler<ActiveEventsQuery, IQueryable<Event>>,
                                    IRequestHandler<AllEventsQuery, IQueryable<Event>>,
                                    IRequestHandler<SingleEventQuery, Event>

    {
        private readonly IEventRepository _eventRepository;

        public EventQueryHandler(IMediator mediator, IUnitOfWork unitOfWork, IEventRepository eventRepository) : base(mediator, unitOfWork)
        {
            _eventRepository = eventRepository;
        }

        public Task<IQueryable<Event>> Handle(ActiveEventsQuery request, CancellationToken cancellationToken)
        {
            var events = _eventRepository.GetActiveEvents();
            return Task.FromResult(events);
        }

        public Task<IQueryable<Event>> Handle(AllEventsQuery request, CancellationToken cancellationToken)
        {
            var events = _eventRepository.GetAll();
            return Task.FromResult(events);
        }

        public Task<Event> Handle(SingleEventQuery request, CancellationToken cancellationToken)
        {
            var _event = _eventRepository.GetSingleEvent(request.Id);
            return Task.FromResult(_event);
        }
    }
}
