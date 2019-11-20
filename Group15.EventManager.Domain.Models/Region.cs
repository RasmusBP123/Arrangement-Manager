using Group15.EventManager.Domain.Core.Models;
using System.Collections.Generic;

namespace Group15.EventManager.Domain.Models
{
    public class Region : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
