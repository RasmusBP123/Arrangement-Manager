using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models.Auth;
using System;
using System.Linq;

namespace Group15.EventManager.Data.Interfaces
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        IQueryable<ApplicationUser> GetAllUsersFromEvent(Guid eventId);
        ApplicationUser GetSingleUser(Guid userId);
        void AddUserToEvent(Guid userId, Guid eventId, int ticketAmount);
        void CancelEventForUser(Guid userId, Guid eventId);
    }
}
