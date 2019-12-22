using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;
using System.Collections.Generic;

namespace Group15.EventManager.Domain.Commands.Tickets
{
    public class UpdateTicketsCommand : Command
    {
        //public int NewCustomerAmount { get; }
        public ApplicationUser User { get; }
        public IEnumerable<Event> Events { get; }

        public UpdateTicketsCommand(ApplicationUser user, IEnumerable<Event> events)
        {
            //NewCustomerAmount = newCustomerAmount;
            User = user;
            Events = events;
        }

    }
}
