using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Handlers;
using Group15.EventManager.Domain.Models.Auth;
using Group15.EventManager.Domain.Queries.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.QueryHandlers
{
    public class UserQueryHandler : Handler, IRequestHandler<AllUsersFromEventQuery, IQueryable<ApplicationUser>>
    {
        private readonly IUserRepository _userRepository;

        public UserQueryHandler(IMediator mediator, IUnitOfWork unitOfWork, IUserRepository userRepository) : base(mediator, unitOfWork)
        {
            _userRepository = userRepository;
        }

        public Task<IQueryable<ApplicationUser>> Handle(AllUsersFromEventQuery request, CancellationToken cancellationToken)
        {
            var users = _userRepository.GetAllUsersFromEvent(request.EventId);
            return Task.FromResult(users);
        }
    }
}
