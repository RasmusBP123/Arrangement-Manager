using Group15.EventManager.Shared.Address_;
using Group15.EventManager.Shared.Tickets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Events
{
    public class GetEventWithTicketsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CurrentAmountOfCustomers { get; set; }
        public int MaxCustomerLimit { get; set; }
        public IEnumerable<GetTicketForCartViewModel> Tickets { get; set; }
        public GetAddressForEventViewModel Address { get; set; }
    }
}
