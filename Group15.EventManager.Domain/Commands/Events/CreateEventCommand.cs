using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;
using System;

namespace Group15.EventManager.Domain.Commands.Events
{
    public class CreateEventCommand : Command
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime LastBookingDate { get; set;}
        public DateTime EndEventDate { get; set; }
        public bool PayOnline { get; set; }
        public int MinCustomerAmount { get; set; }
        public int MaxCustomerLimit { get; set; }
        public Address Address { get; set; }
        public Food Food { get; set; }
        public Region Region { get; set; }
        public City City { get; set; }
        public Marker Marker { get; set; }

        public CreateEventCommand()
        {
                
        }
    }
}
