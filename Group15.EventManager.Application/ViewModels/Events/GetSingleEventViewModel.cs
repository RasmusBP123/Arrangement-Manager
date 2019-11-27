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
        public string Address { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
        public GetFoodViewModel? Food { get; set; }
    }
}
