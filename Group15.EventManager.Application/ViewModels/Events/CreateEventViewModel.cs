using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.ApplicationLayer.ViewModels.Foods;
using Group15.EventManager.ApplicationLayer.ViewModels.Markers;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using System;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Events
{
    public class CreateEventViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int MinCustomerAmount { get; set; }
        public int MaxCustomerLimit { get; set; }
        public bool PayOnline { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime LastBookingDate { get; set; }
        public DateTime EndEventDate { get; set; }

        public CreateAddressForEventViewModel Address { get; set; }

        public CreateFoodViewModel Food { get; set; }
        public GetRegionViewModel Region { get; set; }
        public GetCityViewModel City { get; set; }
        public CreateMarkerViewModel Marker { get; set; }
        public Guid StoreId { get; set; }
    }
}
