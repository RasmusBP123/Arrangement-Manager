using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using System;

namespace Group15.EventManager.Data.Interfaces
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        void AddUserToEvent(Event _event, ApplicationUser user);
    }
}
