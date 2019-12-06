using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Events
{
    public class UpdateEventWithTicketsViewModel
    {
        public Guid Id { get; set; }
        public int CurrentAmountOfCustomers { get; set; }
    }
}
