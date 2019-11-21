using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Foods;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class FoodApplicationService : Service, IFoodApplicationService
    {
        private readonly IFoodRepository _foodRepository;

        public FoodApplicationService(IMapper mapper, IMediator mediator, IFoodRepository foodRepository) : base(mapper, mediator)
        {
            _foodRepository = foodRepository;
        }

        public void AddFoodToEvent(Guid eventId, CreateFoodViewModel foodViewModel)
        {
            var food = _mapper.Map<Food>(foodViewModel);
            _foodRepository.AddFoodToEvent(eventId, food);
        }


        public IEnumerable<GetFoodViewModel> GetAllFoods()
        {
            var foods = _foodRepository.GetAll();
            var foodViewModels = _mapper.Map<IEnumerable<GetFoodViewModel>>(foods);
            return foodViewModels;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
