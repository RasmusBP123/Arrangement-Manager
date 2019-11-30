using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Shared.Events
{
    public class UpdateEventViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int MinCustomerAmount { get; set; }
        public int MaxCustomerLimit { get; set; }
        public byte[] Image { get; set; }
        public bool PayOnline { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime LastBookingDate { get; set; }
        public DateTime EndEventDate { get; set; }
    }
}
