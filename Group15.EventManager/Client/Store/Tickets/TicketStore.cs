﻿using Group15.EventManager.Shared.Tickets;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Client.Store.Tickets
{
    public class TicketStore
    {
        public IEnumerable<GetTicketForCartViewModel> TicketsForCart { get; set; } = new List<GetTicketForCartViewModel>();
        public GetTicketForCartViewModel Ticket { get; set; } = new GetTicketForCartViewModel();

        public event Action OnDeletedTicket;
        public void NotifyTicketState() => OnDeletedTicket?.Invoke();

        public double CalculateTotalPrice(IEnumerable<GetTicketForCartViewModel> tickets)
        {
            double sum = 0;
            foreach (var ticket in tickets)
            {
                sum += ticket.Event.Price;
            }
            return sum;
        }
    }
}
