using AutoMapper;
using Group15.EventManager.Application.ViewModels;
using Group15.EventManager.Domain.Models;

namespace Group15.EventManager.Application.AutoMapper
{
    internal class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Event, GetEventViewModel>();
        }
    }
}