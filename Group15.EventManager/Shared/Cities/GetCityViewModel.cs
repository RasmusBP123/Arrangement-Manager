using Group15.EventManager.Shared.Events;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Shared.Cities
{
    public class GetCityViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Zipcode { get; set; }
    }
}
