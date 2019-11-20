using Group15.EventManager.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Domain.Models
{
    public class Event : Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
        public virtual City City { get; set; }
        public virtual Region Region { get; set; }
        public virtual Food Food { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual Employee Employee { get; set; }
    }

}
