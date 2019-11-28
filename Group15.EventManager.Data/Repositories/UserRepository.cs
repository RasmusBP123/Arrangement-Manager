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

        public void AddUserToEvent(Event _event, ApplicationUser user)
        {
            //Attach existing entities, or else ef will believe you are trying to insert new entities, instead of existing ones
            Db.Set<Event>().Attach(_event);
            Db.Set<ApplicationUser>().Attach(user);
            var userEvents = Db.Set<ApplicationUserEvent>();
            var userEvent = new ApplicationUserEvent() { ApplicationUserId = user.Id, User = user, EventId = _event.Id, Event = _event};
            userEvents.Add(userEvent);
        }

        public IQueryable<ApplicationUser> GetAllUsersFromEvent(Guid eventId)
        {
            var test = Db.Set<ApplicationUserEvent>().Where(ue => ue.EventId == eventId).Include(ue => ue.User);
            var users = test.Select(ue => ue.User).AsQueryable();
            return users;
        }
    }
}
