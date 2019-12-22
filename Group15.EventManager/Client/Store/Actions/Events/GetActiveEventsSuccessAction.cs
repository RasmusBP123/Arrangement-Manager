using Group15.EventManager.Shared.Events;
using System.Collections.Generic;

namespace Group15.EventManager.Client.Store.Actions.Events
{
    public class GetActiveEventsSuccessAction
    {
        public IEnumerable<GetEventListViewModel> _events { get; set; }

        public GetActiveEventsSuccessAction(IEnumerable<GetEventListViewModel> events)
        {
            _events = events;
        }
    }
}
