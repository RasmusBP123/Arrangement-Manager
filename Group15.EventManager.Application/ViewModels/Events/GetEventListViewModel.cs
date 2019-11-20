using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Application.ViewModels.Events
{
    public class GetEventListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public byte[] Image { get; set; }
        public DateTime EventDate { get; set; }
        public GetRegionViewModel Region { get; set; }
    }
}
