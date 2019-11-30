using Group15.EventManager.Shared.Address_;
using Group15.EventManager.Shared.Cities;
using Group15.EventManager.Shared.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Events
{
    public class GetEventListViewModel
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
        public GetAddressForEventViewModel Address { get; set; }
        public GetCityViewModel City { get; set; }
        public GetRegionViewModel Region { get; set; }
    }
}
