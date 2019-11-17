using Group15.EventManager.Application.ViewModels;
using Group15.EventManager.Application.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.Application.Interfaces
{
    public interface IEventApplicationService
    {
        IEnumerable<GetEventListViewModel> GetAllEvents();
        IEnumerable<GetEventListViewModel> GetActiveEvents();
        GetSingleEventViewModel GetSingleEvent(Guid eventId);
        Task CreateEvent(CreateEventViewModel eventViewModel);
        void UpdateEvent(Guid eventId, UpdateEventViewModel eventViewModel);
    }
}
