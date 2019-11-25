using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Interfaces
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        void AddUserToEvent(Guid eventId, ApplicationUser user);
    }
}
