using Group15.EventManager.Shared.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Tickets
{
    public class GetTicketForCartViewModel
    {
        public Guid Id { get; set; }
        public GetSingleEventViewModel Event { get; set; }
    }
}
