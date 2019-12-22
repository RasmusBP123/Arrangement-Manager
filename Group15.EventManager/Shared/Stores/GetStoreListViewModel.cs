using Group15.EventManager.Shared.Address_;
using Group15.EventManager.Shared.Cities;
using Group15.EventManager.Shared.Regions;
using System;

namespace Group15.EventManager.Shared.Stores
{
    public class GetStoreListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GetAddressForEventViewModel Address { get; set; }
        public GetRegionWithoutCitiesViewModel Region { get; set; }
        public GetCityViewModel City { get; set; }
    }
}
