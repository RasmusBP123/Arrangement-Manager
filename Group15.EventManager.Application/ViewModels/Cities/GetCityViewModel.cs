using Group15.EventManager.Application.ViewModels.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Cities
{
    public class GetCityViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Zipcode { get; set; }
        //public IEnumerable<GetEventListViewModel> Events { get; set; }
    }
}
