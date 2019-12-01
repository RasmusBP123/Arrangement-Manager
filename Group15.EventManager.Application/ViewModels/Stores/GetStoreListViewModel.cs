using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Stores
{
    public class GetStoreListViewModel
    {
        public string Name { get; set; }
        public GetAddressForEventViewModel Address { get; set; }
        public GetRegionWithoutCitiesViewModel Region { get; set; }
        public GetCityViewModel City { get; set; }
    }
}
