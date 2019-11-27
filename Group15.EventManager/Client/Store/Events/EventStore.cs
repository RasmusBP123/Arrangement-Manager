using Group15.EventManager.Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Store.Events
{
    public class EventStore
    {
        public List<GetEventListViewModel> Events { get; set; } = new List<GetEventListViewModel>();
        public GetSingleEventViewModel Event { get; set; } = new GetSingleEventViewModel();
        public CreateEventViewModel CreateEvent { get; set; } = new CreateEventViewModel();
        public event Action OnClickedRegion;
        public event Action OnSubmittedEvent;

        public void NotifyEventStateChanged() => OnSubmittedEvent?.Invoke();
        public void NotifyStateChanged() => OnClickedRegion?.Invoke();
    }
}
