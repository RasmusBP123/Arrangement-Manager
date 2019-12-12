using Group15.EventManager.Domain.Core.Models;
using Group15.EventManager.Domain.Models.Auth;
using Group15.EventManager.Domain.Models.Joint;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Group15.EventManager.Domain.Models
{
    public class Event : Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public bool PayOnline { get; set; }
        public int MinCustomerAmount { get; set; }
        public int CurrentAmountOfCustomers { get => Tickets.Count; }
        public int MaxCustomerLimit { get; set; }
        public DateTime LastBookingDate { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EndEventDate { get; set; }
        public Address Address { get; set; }
        public virtual Attendance Attendance { get; set; }
        public virtual City City { get; set; }
        public virtual Region Region { get; set; }
        public virtual Food Food { get; set; }
        public ICollection<ApplicationUserEvent> UserEvents { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        //public virtual Employee Employee { get; set; }
        public virtual ApplicationUser Employee { get; set; }
    }
}
