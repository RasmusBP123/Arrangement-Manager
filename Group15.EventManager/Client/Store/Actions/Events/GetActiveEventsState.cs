using Group15.EventManager.Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Group15.EventManager.Client.Store.Events
{
    public class GetActiveEventsState
    {
        public bool IsLoading { get; set; }
        public string ErrorMessage { get; set; }
        public IEnumerable<GetEventListViewModel> Events { get; set; }
        public GetActiveEventsState(bool isLoading, string errorMessage, IEnumerable<GetEventListViewModel> events)
        {
            IsLoading = isLoading;
            ErrorMessage = errorMessage;
            Events = events == null ? null : Events.ToList();
        }

        [Obsolete("Serialization only")]
        public GetActiveEventsState()
        {

        }
    }
}
