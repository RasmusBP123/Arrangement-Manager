using Group15.EventManager.Shared.Address_;
using Group15.EventManager.Shared.Food;
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
        public DateTime EventDate { get; set; }
        public bool PayOnline { get; set; }
        public GetAddressForEventViewModel Address { get; set; }
        public GetFoodViewModel Food { get; set; }
    }
}
