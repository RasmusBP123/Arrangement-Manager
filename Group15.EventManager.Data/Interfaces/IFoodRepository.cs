using Group15.EventManager.Domain.Core.Repositories;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.Data.Interfaces
{
    public interface IFoodRepository : IRepository<Food>
    {
        void AddFoodToEvent(Guid eventId, Food food);
    }
}
