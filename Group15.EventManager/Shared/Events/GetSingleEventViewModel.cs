using Group15.EventManager.Shared.Address_;
using Group15.EventManager.Shared.Attendances;
using Group15.EventManager.Shared.Cities;
using Group15.EventManager.Shared.Food;
using Group15.EventManager.Shared.Marker;
using System;

namespace Group15.EventManager.Shared.Events
{
    public class GetSingleEventViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int MinCustomerAmount { get; set; }
        public int MaxCustomerLimit { get; set; }
        public int CurrentAmountOfCustomers { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime LastBookingDate { get; set; }
        public DateTime EndEventDate { get; set; }
        public bool PayOnline { get; set; }
        public GetAddressForEventViewModel Address { get; set; }
        public GetAttendanceViewModel Attendance { get; set; }
        public GetMarkerViewModel Marker { get; set; }
        public GetCityViewModel City { get; set; }
        public GetFoodViewModel Food { get; set; }
    }
}
