using Group15.EventManager.Data.UnitOfWork;
using MediatR;

namespace Group15.EventManager.Domain.Handlers
{
    public class Handler
    {
        protected readonly IMediator _mediator;
        protected readonly IUnitOfWork _unitOfWork;

        public Handler(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }
    }
}
