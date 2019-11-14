using Group15.EventManager.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Domain.Models
{
    public class Store : Entity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
