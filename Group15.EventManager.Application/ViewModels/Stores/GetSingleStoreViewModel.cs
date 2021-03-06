﻿using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.ApplicationLayer.ViewModels.Markers;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using System;

namespace Group15.EventManager.ApplicationLayer.ViewModels.Stores
{
    public class GetSingleStoreViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GetAddressForEventViewModel Address { get; set; }
        public GetRegionWithoutCitiesViewModel Region { get; set; }
        public GetCityViewModel City { get; set; }
        public GetMarkerViewModel Marker { get; set; }
    }
}
