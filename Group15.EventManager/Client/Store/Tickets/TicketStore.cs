using Group15.EventManager.Shared.Events;
using Group15.EventManager.Shared.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Group15.EventManager.Client.Store.Tickets
{
    public class TicketStore
    {
        public IEnumerable<GetTicketForCartViewModel> TicketsForCart { get; set; } = new List<GetTicketForCartViewModel>();
        public GetTicketForCartViewModel Ticket { get; set; } = new GetTicketForCartViewModel();
        public event Action OnDeletedTicket;
        public void NotifyTicketState() => OnDeletedTicket?.Invoke();

        public double CalculateTotalPrice(IEnumerable<GetEventWithTicketsViewModel> events)
        {
            double sum = 0;
            foreach (var _event in events)
            {
                foreach (var ticket in _event.Tickets)
                {
                     sum += _event.Price;
                }
            }
            return sum;
        }

        public double CalculateTax(double sum)
        {
            var moms = sum / 1.25;
            return sum - moms;
        }
    }
}
