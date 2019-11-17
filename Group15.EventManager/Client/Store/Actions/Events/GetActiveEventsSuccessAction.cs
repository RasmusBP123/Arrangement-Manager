using Group15.EventManager.Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
