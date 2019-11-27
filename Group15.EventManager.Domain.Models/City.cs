using Group15.EventManager.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Domain.Models
{
    public class City : Entity
    {
        public string Name { get; set; }
        public int Zipcode { get; set; }
        public Guid RegionId { get; set; }
        public Region Region { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
