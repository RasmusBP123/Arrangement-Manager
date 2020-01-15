using Group15.EventManager.Shared.Address_;
using Group15.EventManager.Shared.Cities;
using Group15.EventManager.Shared.Employees;
using Group15.EventManager.Shared.Food;
using Group15.EventManager.Shared.Marker;
using Group15.EventManager.Shared.Regions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Group15.EventManager.Shared.Events
{
    public class CreateEventViewModel
    {
        [Required(ErrorMessage = "Event must have a name")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int MinCustomerAmount { get; set; }
        public int MaxCustomerLimit { get; set; }
        public bool PayOnline { get; set; }
        [Required(ErrorMessage = "Event must have a date")]
        public DateTime EventDate { get; set; }
        public DateTime LastBookingDate { get; set; }
        public DateTime EndEventDate { get; set; }
        public CreateAddressForEventViewModel Address { get; set; }
        public CreateFoodViewModel Food { get; set; }
        public GetRegionViewModel Region { get; set; }
        public GetCityViewModel City { get; set; }
        public EmployeeCreateEventViewModel Employee { get; set; }
        public CreateMarkerViewModel Marker { get; set; }
        public Guid StoreId { get; set; }
    }
}
