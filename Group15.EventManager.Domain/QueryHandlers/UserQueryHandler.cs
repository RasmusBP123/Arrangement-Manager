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
    public class UserQueryHandler : IRequestHandler<AllUsersFromEventQuery, IQueryable<ApplicationUser>>
                                   ,IRequestHandler<SingleUserQuery, ApplicationUser>
    {
        private readonly IUserRepository _userRepository;

        public UserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<IQueryable<ApplicationUser>> Handle(AllUsersFromEventQuery request, CancellationToken cancellationToken)
        {
            var users = _userRepository.GetAllUsersFromEvent(request.EventId);
            return Task.FromResult(users);
        }

        public Task<ApplicationUser> Handle(SingleUserQuery request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetSingleUser(request.UserId);
            return Task.FromResult(user);
        }
    }
}
