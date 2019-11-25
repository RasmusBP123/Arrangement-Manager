using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Users;
using Group15.EventManager.Domain.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.CommandHandlers
{
    public class UserCommandHandler : Handler, IRequestHandler<AddUserToEventCommand, bool>
    {
        public UserCommandHandler(IMediator mediator, IUnitOfWork unitOfWork) : base(mediator, unitOfWork)
        {
        }

        public Task<bool> Handle(AddUserToEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
