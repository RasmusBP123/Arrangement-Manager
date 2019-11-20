using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Events;
using Group15.EventManager.Domain.Handlers;
using Group15.EventManager.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.CommandHandlers
{
    public class EventCommandHandler : Handler, IRequestHandler<CreateEventCommand, bool>,
                                                IRequestHandler<UpdateEventCommand, bool>,
                                                IRequestHandler<DeleteEventCommand, bool>
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
                Address = request.Address,
                Image = request.Image,
            };

            _eventRepository.Add(_event);

            _unitOfWork.Commit();

            return Task.FromResult(true);
        }

        public Task<bool> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var _event = new Event()
            {
                Id = request.Id,
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
                EventDate = request.EventDate,
                Address = request.Address,
                Image = request.Image,
            };

            _eventRepository.Update(_event);

            _unitOfWork.Commit();

            return Task.FromResult(true);
        }

        public Task<bool> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            _eventRepository.Remove(request.EventId);
            _unitOfWork.Commit();
            return Task.FromResult(true);
        }
    }
}
