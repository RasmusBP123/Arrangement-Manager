using AutoMapper;
using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.ViewModels.Foods;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using Group15.EventManager.ApplicationLayer.ViewModels.Stores;
using Group15.EventManager.ApplicationLayer.ViewModels.Users;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;

namespace Group15.EventManager.Application.AutoMapper
{
    internal class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CreateAddressForEventViewModel, Address>();
            CreateMap<CreateEventViewModel, Event>();
            CreateMap<UpdateEventViewModel, Event>();
            CreateMap<CreateFoodViewModel, Food>();
            CreateMap<AddUserToEventViewModel, ApplicationUser>();
            CreateMap<UserModel, ApplicationUser>();
            CreateMap<CreateStoreViewModel, Store>();

            //ViewModels which should be added to new entities
            CreateMap<GetSingleEventViewModel, Event>();
            CreateMap<GetRegionViewModel, Region>();
            CreateMap<GetFoodViewModel, Food>();
            CreateMap<GetCityViewModel, City>();
        }
    }
}