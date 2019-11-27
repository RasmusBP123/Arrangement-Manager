﻿using AutoMapper;
using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.Application.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.ViewModels.Foods;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;

namespace Group15.EventManager.Application.AutoMapper
{
    internal class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Address, GetAddressForEventViewModel>();
            CreateMap<Event, GetEventListViewModel>();
            CreateMap<Event, GetSingleEventViewModel>();
            CreateMap<Food, GetFoodViewModel>();
            CreateMap<City, GetCityViewModel>();
            CreateMap<Region, GetRegionViewModel>();
            CreateMap<Region, AddRegionForEventViewModel>();
            CreateMap<ApplicationUser, UserModel>();
        }
    }
}