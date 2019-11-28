using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Events
{
    public class UpdateEventViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; }
        public bool PayOnline { get; set; }
        public int MinCustomerAmount { get; set; }
        public int MaxCustomerLimit { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime LastBookingDate { get; set; }

        public GetAddressForEventViewModel Address { get; set; }
    }
}
