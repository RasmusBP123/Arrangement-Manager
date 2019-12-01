using Group15.EventManager.Domain.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Domain.Models
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
