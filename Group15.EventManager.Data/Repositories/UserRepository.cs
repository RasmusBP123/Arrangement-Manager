using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using Group15.EventManager.Domain.Models.Joint;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Group15.EventManager.Data.Repositories
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        public UserRepository(SqlContext context) : base(context)
        {
        }

        public void AddUserToEvent(Guid userId, Guid eventId)
        {
            var userEvents = Db.Set<ApplicationUserEvent>();
            var userEvent = new ApplicationUserEvent() { ApplicationUserId = userId, EventId = eventId };
            userEvents.Add(userEvent);
        }

        public void CancelEventForUser(Guid userId, Guid eventId)
        {
            var userEvent = Db.Set<ApplicationUserEvent>().FirstOrDefault(aue => aue.ApplicationUserId == userId && aue.EventId == eventId);
            Db.Remove(userEvent);
        }

        public IQueryable<ApplicationUser> GetAllUsersFromEvent(Guid eventId)
        {
            var userEvents = Db.Set<ApplicationUserEvent>().Where(ue => ue.EventId == eventId).Include(ue => ue.User);
            var users = userEvents.Select(ue => ue.User).AsQueryable();
            return users;
        }
    }
}
