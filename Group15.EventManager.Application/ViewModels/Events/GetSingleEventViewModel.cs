using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.ApplicationLayer.ViewModels.Foods;
using System;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Events
{
    public class GetSingleEventViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime LastBookingDate { get; set; }
        public DateTime EndEventDate { get; set; }
        public bool PayOnline { get; set; }
        // public GetAddressForEventViewModel Address { get; set; }
        public GetFoodViewModel Food { get; set; }
        public GetCityViewModel City { get; set; }
    }
}
