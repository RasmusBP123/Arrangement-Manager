using AutoMapper;
using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.Application.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.ViewModels.Address_;
using Group15.EventManager.ApplicationLayer.ViewModels.Attendances;
using Group15.EventManager.ApplicationLayer.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.ViewModels.Foods;
using Group15.EventManager.ApplicationLayer.ViewModels.Markers;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using Group15.EventManager.ApplicationLayer.ViewModels.Stores;
using Group15.EventManager.ApplicationLayer.ViewModels.Tickets;
using Group15.EventManager.ApplicationLayer.ViewModels.Users;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;

namespace Group15.EventManager.Application.AutoMapper
{
    internal class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Attendance, GetAttendanceViewModel>();
            CreateMap<Address, GetAddressForEventViewModel>();
            CreateMap<ApplicationUser, UserModel>();
            CreateMap<ApplicationUser, GetUserFromEventViewModel>();
            CreateMap<City, GetCityViewModel>();
            CreateMap<Event, GetEventListViewModel>();
            CreateMap<Event, GetSingleEventViewModel>();
            CreateMap<Event, GetEventWithTicketsViewModel>();
            CreateMap<Food, GetFoodViewModel>();
            CreateMap<Marker, GetMarkerViewModel>();
            CreateMap<Region, GetRegionViewModel>();
            CreateMap<Region, GetRegionWithoutCitiesViewModel>();
            CreateMap<Region, AddRegionForEventViewModel>();
            CreateMap<Store, GetStoreListViewModel>();
            CreateMap<Store, GetSingleStoreViewModel>();
            CreateMap<Ticket, GetTicketForCartViewModel>();
            CreateMap<Ticket, GetTicketViewModel>();
        }
    }
}