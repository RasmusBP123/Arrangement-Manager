using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Stores
{
    public class CreateStoreViewModel
    {
        public string Name { get; set; }
        public CreateAddressForEventViewModel Address { get; set; }
        public GetRegionViewModel Region { get; set; }
        public GetCityViewModel City { get; set; }
    }
}
