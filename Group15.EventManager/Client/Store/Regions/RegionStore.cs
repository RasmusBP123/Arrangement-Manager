using Group15.EventManager.Shared.Cities;
using Group15.EventManager.Shared.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Store.Regions
{
    public class RegionStore
    {
        public IEnumerable<GetRegionViewModel> Regions { get; set; } = new List<GetRegionViewModel>();
        public IEnumerable<GetCityViewModel> Cities { get; set; } = new List<GetCityViewModel>();
        public GetRegionViewModel region = new GetRegionViewModel();

    }
}
