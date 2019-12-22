using Group15.EventManager.Shared.Cities;
using Group15.EventManager.Shared.Regions;
using System.Collections.Generic;

namespace Group15.EventManager.Client.Store.Regions
{
    public class RegionStore
    {
        public IEnumerable<GetRegionViewModel> Regions { get; set; } = new List<GetRegionViewModel>();
        public IEnumerable<GetCityViewModel> Cities { get; set; } = new List<GetCityViewModel>();
        public GetRegionViewModel Region = new GetRegionViewModel();

        public AddRegionForEventViewModel RegionToBeAdded = new AddRegionForEventViewModel();
    }
}
