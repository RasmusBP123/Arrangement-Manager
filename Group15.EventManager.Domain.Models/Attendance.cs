using Group15.EventManager.Domain.Core.Models;
using System;

namespace Group15.EventManager.Domain.Models
{
    public class Attendance : Entity
    {
        public int Invited { get; set; }
        public int Registered { get; set; }
        public int NotRegistred { get; set; }
        public int MinCustomerAmount { get; set; }
        public int MaxCustomerLimit { get; set; }
        public int CurrentAmountOfCustomers => Event.Tickets.Count;
        public bool Finished { get; set; }
        public Guid EventId { get; set; }
        public Event Event { get; set; }
    }
}
