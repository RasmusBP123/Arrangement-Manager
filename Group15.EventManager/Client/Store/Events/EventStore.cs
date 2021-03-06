﻿using Group15.EventManager.Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Group15.EventManager.Client.Store.Events
{
    public class EventStore
    {
        public IEnumerable<GetEventListViewModel> Events = new List<GetEventListViewModel>();
        public IEnumerable<GetEventListViewModel> EventsWithBookedUsers = new List<GetEventListViewModel>();

        public IEnumerable<GetEventListViewModel> BookedEvents { get; set; } = new List<GetEventListViewModel>();
        public IEnumerable<GetEventWithTicketsViewModel> EventsWithTickets { get; set; } = new List<GetEventWithTicketsViewModel>();
        public GetSingleEventViewModel Event { get; set; } = new GetSingleEventViewModel();
        public CreateEventViewModel CreateEvent { get; set; } = new CreateEventViewModel();
        public event Action OnDeletedEvent;
        public event Action OnClickedRegion;
        public event Action OnSubmittedEvent;

        public event Action OnBookedEvent;
        public void NotifyBookedEvent() => OnBookedEvent?.Invoke();

        public void NotifyEventStateChanged() => OnSubmittedEvent?.Invoke();
        public void NotifyStateChanged() => OnClickedRegion?.Invoke();
        public void NotifyEventDeleted() => OnDeletedEvent?.Invoke();

        public bool ShowWarning = false;

        public string SearchTerm = "";
        public IEnumerable<GetEventListViewModel> EventSearch(IEnumerable<GetEventListViewModel> events)
        {
            return events.Where(e => e.Name.ToLower().Contains(SearchTerm.ToLower()));
        }
    }
}
