using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Events
{
    public class UpdateEventViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
    }
}
