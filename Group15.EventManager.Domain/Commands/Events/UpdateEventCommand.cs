using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;
using System;

namespace Group15.EventManager.Domain.Commands.Events
{
    public class UpdateEventCommand : Command
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }

        public UpdateEventCommand(Guid id)
        {
            Id = id;
        }
    }
}
