using AutoMapper;
using Group15.EventManager.Application.Interfaces;
using Group15.EventManager.Application.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.Services;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Events;
using Group15.EventManager.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Group15.EventManager.Application.Services
{
    public class EventApplicationService : Service, IEventApplicationService
    {
        private readonly IEventRepository _eventRepository;

        public EventApplicationService(IUnitOfWork unitOfWork, IMapper mapper, IMediator mediator, IEventRepository eventRepository) : base(unitOfWork, mapper, mediator)
        {
            _eventRepository = eventRepository;
        }

        public IEnumerable<GetEventListViewModel> GetAllEvents()
        {
            var events =  _eventRepository.GetAll();
            var eventViewModels = _mapper.Map<IEnumerable<GetEventListViewModel>>(events);
            return eventViewModels;
        }

        public IEnumerable<GetEventListViewModel> GetActiveEvents()
        {
            var events = _eventRepository.GetActiveEvents();
            var eventViewModels = _mapper.Map<IEnumerable<GetEventListViewModel>>(events);
            return eventViewModels;
        }

        public GetSingleEventViewModel GetSingleEvent(Guid eventId)
        {
            var _event = _eventRepository.GetSingleEvent(eventId);
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

        public void UpdateEvent(Guid eventId, UpdateEventViewModel eventViewModel)
        {
            var _event = _mapper.Map<Event>(eventViewModel);
            _eventRepository.Update(_event);
            _unitOfWork.Commit();
        }
    }
}
