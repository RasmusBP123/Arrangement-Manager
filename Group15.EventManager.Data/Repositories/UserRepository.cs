using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group15.EventManager.Data.Repositories
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        public UserRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }

        public void AddUserToEvent(Guid eventId, ApplicationUser user)
        {
            //var _event = Db.Set<Event>().Include(e => e.UserEvents).FirstOrDefault(e => e.Id == eventId);
            //_event.UserEvents.Add(user);
        }
    }
}
