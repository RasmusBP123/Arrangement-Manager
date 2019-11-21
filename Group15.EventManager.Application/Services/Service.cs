using AutoMapper;
using Group15.EventManager.Data.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

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
