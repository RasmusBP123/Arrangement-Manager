using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Users;
using Group15.EventManager.Domain.Handlers;
using Group15.EventManager.Domain.Models.Auth;
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
        private readonly IUserRepository _userRepository;

        public UserCommandHandler(IMediator mediator, IUnitOfWork unitOfWork, IUserRepository userRepository) : base(mediator, unitOfWork)
        {
            _userRepository = userRepository;
        }

        public Task<bool> Handle(AddUserToEventCommand request, CancellationToken cancellationToken)
        {
            _userRepository.AddUserToEvent(request.Event, request.User);
            _unitOfWork.Commit();

            return Task.FromResult(true);
        }
    }
}
