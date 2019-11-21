using AutoMapper;
using Group15.EventManager.Application.ViewModels.Auth;
using Group15.EventManager.ApplicationLayer.ViewModels.Customers;
using Group15.EventManager.ApplicationLayer.ViewModels.Events;
using Group15.EventManager.ApplicationLayer.ViewModels.Foods;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Models.Auth;

namespace Group15.EventManager.Application.AutoMapper
{
    internal class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CreateEventViewModel, Event>();
            CreateMap<UpdateEventViewModel, Event>();
            CreateMap<CreateFoodViewModel, Food>();
            CreateMap<SignUpCustomerViewModel, Customer>();
            CreateMap<RegisterModel, ApplicationUser>();
        }
    }
}