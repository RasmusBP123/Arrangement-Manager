using Group15.EventManager.ApplicationLayer.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface IUserApplicationService : IDisposable
    {
        Task<IEnumerable<GetUserFromEventViewModel>> GetUsersFromEvent(Guid eventId);
        Task AddUserToEvent(AddUserToEventViewModel userViewModel);
        Task CancelEventFromUser(Guid userId, Guid eventId);
    }
}
