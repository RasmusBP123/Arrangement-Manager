using AutoMapper;
using Group15.EventManager.Application.Interfaces;
using Group15.EventManager.Application.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.Services;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Events;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Application.Services
{
    public class EventApplicationService : Service, IEventApplicationService
    {
        public EventApplicationService(IUnitOfWork unitOfWork, IMapper mapper, IMediator mediator) : base(unitOfWork, mapper, mediator)
        { }

        public async Task<IEnumerable<GetEventListViewModel>> GetAllEvents()
        {
            var events = await _mediator.Send(new AllEventsQuery());
            var eventViewModels = _mapper.Map<IEnumerable<GetEventListViewModel>>(events);
            return eventViewModels;
        }

        public async Task<IEnumerable<GetEventListViewModel>> GetActiveEvents()
        {
            var events = await _mediator.Send(new ActiveEventsQuery());
            var eventViewModels = _mapper.Map<IEnumerable<GetEventListViewModel>>(events);
            return eventViewModels;
        }

        public async Task<GetSingleEventViewModel> GetSingleEvent(Guid eventId)
        {
            var _event = await _mediator.Send(new SingleEventQuery(eventId));
            var eventViewModel = _mapper.Map<GetSingleEventViewModel>(_event);
            return eventViewModel;
        }

        public async Task CreateEvent(CreateEventViewModel eventViewModel)
        {
            var _event = _mapper.Map<Event>(eventViewModel);

            await _mediator.Send(new CreateEventCommand() 
            {   
                Name = _event.Name,
                Description = _event.Description, 
                EventDate = _event.EventDate,
                Image = _event.Image, 
                Location = _event.Location,
                Price = _event.Price
            });
        }

        public async Task UpdateEvent(Guid eventId, UpdateEventViewModel eventViewModel)
        {
            var _event = _mapper.Map<Event>(eventViewModel);
            await _mediator.Send(new UpdateEventCommand(eventViewModel.Id) 
            {
                Name = _event.Name,
                Description = _event.Description,
                EventDate = _event.EventDate,
                Image = _event.Image,
                Location = _event.Location,
                Price = _event.Price
            });
        }

        public async Task DeleteEvent(Guid eventId)
        {
            await _mediator.Send(new DeleteEventCommand(eventId));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
