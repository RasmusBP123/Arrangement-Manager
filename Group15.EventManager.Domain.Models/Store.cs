using Group15.EventManager.Domain.Core.Models;
using Group15.EventManager.Domain.Models.Auth;
using System.Collections.Generic;

namespace Group15.EventManager.Domain.Models
{
    public class Store : Entity
    {
        public string Name { get; set; }
        public Address Site { get; set; }
        public virtual Region Region { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
