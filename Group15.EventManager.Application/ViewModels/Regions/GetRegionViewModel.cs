using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Regions
{
    public class GetRegionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<GetCityViewModel> Cities { get; set; }
    }
}
