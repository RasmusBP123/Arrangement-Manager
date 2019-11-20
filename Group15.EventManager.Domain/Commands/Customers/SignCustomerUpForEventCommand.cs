using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Domain.Commands.Customers
{
    public class SignCustomerUpForEventCommand : Command
    {
        public Guid EventId { get; }
        public Customer Customer { get; }
        public SignCustomerUpForEventCommand(Guid eventId, Customer customer)
        {
            EventId = eventId;
            Customer = customer;
        }
    }
}
