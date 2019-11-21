﻿using Group15.EventManager.Domain.Core.Commands;
using System;

namespace Group15.EventManager.Domain.Commands.Events
{
    public class CreateEventCommand : Command
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }

        public CreateEventCommand()
        {
                
        }
    }
}