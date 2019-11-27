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
        public Address Address { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
        public Food Food { get; set; }
        public Region Region { get; set; }
        public City City { get; set; }

        public CreateEventCommand()
        {
                
        }
    }
}
