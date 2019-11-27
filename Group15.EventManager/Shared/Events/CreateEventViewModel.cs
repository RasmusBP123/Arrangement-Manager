using Group15.EventManager.Shared.Address_;
using Group15.EventManager.Shared.Cities;
using Group15.EventManager.Shared.Food;
using Group15.EventManager.Shared.Regions;
using System;

namespace Group15.EventManager.Shared.Events
{
    public class CreateEventViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public CreateAddressForEventViewModel Address { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
        public CreateFoodViewModel Food { get; set; }
        public GetRegionViewModel Region { get; set; }
        public GetCityViewModel City { get; set; }
    }
}
