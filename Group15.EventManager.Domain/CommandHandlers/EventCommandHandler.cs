using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Events;
using Group15.EventManager.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.CommandHandlers
{
    public class EventCommandHandler : CommandHandler, IRequestHandler<CreateEventCommand, bool>
    {
        private readonly IEventRepository _eventRepository;

        public EventCommandHandler(IMediator mediator, IUnitOfWork unitOfWork, IEventRepository eventRepository) : base(mediator, unitOfWork)
        {
            _eventRepository = eventRepository;
        }

        public Task<bool> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var _event = new Event()
            {   
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
                EventDate = request.EventDate,
                Location = request.Location,
                Image = request.Image,
            };

            _eventRepository.Add(_event);

            _unitOfWork.Commit();

            return Task.FromResult(true);
        }
    }
}
