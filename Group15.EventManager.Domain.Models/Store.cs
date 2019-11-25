using Group15.EventManager.Domain.Core.Models;
using Group15.EventManager.Domain.Models.Auth;
using System.Collections.Generic;

namespace Group15.EventManager.Domain.Models
{
    public class Store : Entity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        
    }
}
