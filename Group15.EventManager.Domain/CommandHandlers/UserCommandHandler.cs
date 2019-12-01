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
    public class UserCommandHandler : Handler, IRequestHandler<AddUserToEventCommand, bool>,
                                               IRequestHandler<CancelEventForUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;

        public UserCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository) : base(unitOfWork)
        {
            _userRepository = userRepository;
        }

        public Task<bool> Handle(AddUserToEventCommand request, CancellationToken cancellationToken)
        {
            _userRepository.AddUserToEvent(request.UserId, request.EventId);
            _unitOfWork.Commit();

            return Task.FromResult(true);
        }

        public Task<bool> Handle(CancelEventForUserCommand request, CancellationToken cancellationToken)
        {
            _userRepository.CancelEventForUser(request.UserId, request.EventId);
            _unitOfWork.Commit();
            return Task.FromResult(true);
        }
    }
}
