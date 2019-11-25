using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using System;
using System.Linq;

namespace Group15.EventManager.Data.Repositories
{
    public class FoodRepository : Repository<Food>, IFoodRepository
    {
        public FoodRepository(SqlContext context) : base(context)
        {
        }

        public void AddFoodToEvent(Guid eventId, Food food)
        {
            var _event = Db.Set<Event>().FirstOrDefault(e => e.Id == eventId);
            _event.Food = food;
        }
    }
}
