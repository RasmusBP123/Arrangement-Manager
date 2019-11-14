using Group15.EventManager.Domain.Core.Models;

namespace Group15.EventManager.Domain.Models
{
    public class Food : Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
