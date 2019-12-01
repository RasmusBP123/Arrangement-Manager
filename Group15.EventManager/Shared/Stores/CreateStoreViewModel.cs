using Group15.EventManager.Shared.Address_;
using Group15.EventManager.Shared.Cities;
using Group15.EventManager.Shared.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Stores
{
    public class CreateStoreViewModel
    {
        public string Name { get; set; }
        public CreateAddressForEventViewModel Address { get; set; }
        public GetRegionViewModel Region { get; set; }
        public GetCityViewModel City { get; set; }
    }
}
