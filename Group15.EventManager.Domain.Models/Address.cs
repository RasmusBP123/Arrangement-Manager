using Group15.EventManager.Domain.Core.Models;

namespace Group15.EventManager.Domain.Models
{
    public class Address : Entity
    {
        public string RoadName { get; set; }
        public int RoadNumber { get; set; }
    }
}
