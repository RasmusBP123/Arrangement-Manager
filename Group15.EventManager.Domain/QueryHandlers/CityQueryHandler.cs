using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Handlers;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Cities;
using Group15.EventManager.Domain.Queries.Regions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.QueryHandlers
{
    public class CityQueryHandler : IRequestHandler<SingleCityQuery, City>
    {
        private readonly ICityRepository _cityRepository;

        public CityQueryHandler(ICityRepository cityRepository) 
        {
            _cityRepository = cityRepository;
        }

        public Task<City> Handle(SingleCityQuery request, CancellationToken cancellationToken)
        {
            var city = _cityRepository.GetById(request.CityId);
            return Task.FromResult(city);
        }
    }
}
