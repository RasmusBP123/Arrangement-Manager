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
        public double Price { get; set; }
        public string Description { get; set; }
        public GetAddressForEventViewModel Address { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
    }
}
