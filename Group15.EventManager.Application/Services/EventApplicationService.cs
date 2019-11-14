using AutoMapper;
using Group15.EventManager.Application.Interfaces;
using Group15.EventManager.Application.ViewModels;
using Group15.EventManager.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.Application.Services
{
    public class EventApplicationService : IEventApplicationService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventApplicationService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetEventViewModel>> GetAllEvents()
        {
            var events =  await _eventRepository.GetAll();
            var eventViewModels = _mapper.Map<IEnumerable<GetEventViewModel>>(events);
            return eventViewModels;
        }
    }
}
