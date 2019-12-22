using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using System;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface ICityApplicationService : IDisposable
    {
        Task<GetCityViewModel> GetSingleCity(Guid cityId);
    }
}
