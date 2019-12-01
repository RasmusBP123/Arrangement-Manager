using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Handlers;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Events;
using Group15.EventManager.Domain.Queries.Events.Filters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.QueryHandlers
{
    public class EventQueryHandler :IRequestHandler<AllActiveEventsQuery, IQueryable<Event>>,
                                    IRequestHandler<AllEventsQuery, IQueryable<Event>>,
                                    IRequestHandler<AllEventsByRegionQuery, IQueryable<Event>>,
                                    IRequestHandler<AllEventsByRegionAndCityQuery, IQueryable<Event>>,
                                    IRequestHandler<AllEventsForUserQuery, IQueryable<Event>>,
                                    IRequestHandler<SingleEventQuery, Event>

    {
        private readonly IEventRepository _eventRepository;

        public EventQueryHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public Task<IQueryable<Event>> Handle(AllActiveEventsQuery request, CancellationToken cancellationToken)
        {
            var events = _eventRepository.GetActiveEvents();
            return Task.FromResult(events);
        }

        public Task<IQueryable<Event>> Handle(AllEventsQuery request, CancellationToken cancellationToken)
        {
            var events = _eventRepository.GetAll();
            return Task.FromResult(events);
        }
        public Task<IQueryable<Event>> Handle(AllEventsByRegionQuery request, CancellationToken cancellationToken)
        {
            var events = _eventRepository.GetEventsByRegion(request.RegionId);
            return Task.FromResult(events);
        }
        public Task<IQueryable<Event>> Handle(AllEventsByRegionAndCityQuery request, CancellationToken cancellationToken)
        {
            var events = _eventRepository.GetEventsByRegionAndCity(request.RegionId, request.CityId);
            return Task.FromResult(events);
        }

        //TO DO
        public Task<IQueryable<Event>> Handle(AllEventsForUserQuery request, CancellationToken cancellationToken)
        {
            var events = _eventRepository.GetEventsForUser(request.UserId);
            return Task.FromResult(events);
        }

        public Task<Event> Handle(SingleEventQuery request, CancellationToken cancellationToken)
        {
            var _event = _eventRepository.GetSingleEvent(request.Id);
            return Task.FromResult(_event);
        }

    }
}
