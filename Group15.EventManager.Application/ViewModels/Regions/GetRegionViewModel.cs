using Group15.EventManager.Application.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Regions
{
    public class GetRegionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<GetCityViewModel> Cities { get; set; }
    }
}
