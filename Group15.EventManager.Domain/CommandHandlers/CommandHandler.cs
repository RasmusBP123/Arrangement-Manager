using Group15.EventManager.Data.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Domain.CommandHandlers
{
    public class CommandHandler
    {
        protected readonly IMediator _mediator;
        protected readonly IUnitOfWork _unitOfWork;

        public CommandHandler(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }
    }
}
