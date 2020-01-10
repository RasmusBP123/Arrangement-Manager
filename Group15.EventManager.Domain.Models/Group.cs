using Group15.EventManager.Domain.Core.Models;
using Group15.EventManager.Domain.Models.Joint;
using System.Collections.Generic;

namespace Group15.EventManager.Domain.Models
{
    public class Group : Entity
    {
        public string Name { get; set; }
        public double Discount { get; set; }
        //public virtual ICollection<ApplicationUserGroup> Users { get; set; }
    }
}
