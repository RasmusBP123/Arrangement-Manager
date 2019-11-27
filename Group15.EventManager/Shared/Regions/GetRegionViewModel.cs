using Group15.EventManager.Shared.Cities;
using Group15.EventManager.Shared.Events;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Shared.Regions
{
    public class GetRegionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<GetCityViewModel> Cities { get; set; }
    }
}
