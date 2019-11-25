using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface IRegionApplicationService : IDisposable
    {
        Task<IEnumerable<GetRegionViewModel>> GetAllRegions();
        Task<GetRegionViewModel> GetSingleRegion(Guid regionId);
    }
}
