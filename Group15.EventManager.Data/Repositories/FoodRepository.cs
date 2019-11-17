using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.Data.Repositories
{
    public class FoodRepository : Repository<Food>, IFoodRepository
    {
        public FoodRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }

        public void AddFoodToEvent(Guid eventId, Food food)
        {
            var _event = Db.Set<Event>().FirstOrDefault(e => e.Id == eventId);
            _event.Food = food;
        }
    }
}
