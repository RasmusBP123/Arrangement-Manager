using Group15.EventManager.ApplicationLayer.ViewModels.Foods;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface IFoodApplicationService
    {
        IEnumerable<GetFoodViewModel> GetAllFoods();
        void AddFoodToEvent(Guid eventId, CreateFoodViewModel foodViewModel);
    }
}
