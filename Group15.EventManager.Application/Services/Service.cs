using AutoMapper;
using MediatR;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class Service
    {
        protected readonly IMapper _mapper;
        protected readonly IMediator _mediator;

        public Service( IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }
    }
}
