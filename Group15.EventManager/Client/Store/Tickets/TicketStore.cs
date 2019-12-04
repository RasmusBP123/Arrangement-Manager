using Group15.EventManager.Shared.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Store.Tickets
{
    public class TicketStore
    {
        public IEnumerable<GetTicketForCartViewModel> TicketsForCart { get; set; } = new List<GetTicketForCartViewModel>();
        public GetTicketForCartViewModel Ticket { get; set; } = new GetTicketForCartViewModel();

        public event Action OnDeletedTicket;
        public void NotifyTicketState() => OnDeletedTicket?.Invoke();
    }
}
