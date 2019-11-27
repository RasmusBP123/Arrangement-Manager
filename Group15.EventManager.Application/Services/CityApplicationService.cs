using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Cities;
using Group15.EventManager.Domain.Queries.Cities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class CityApplicationService : Service, ICityApplicationService 
    {
        public CityApplicationService(IMapper mapper, IMediator mediator) : base(mapper, mediator)
        {
        }

        public async Task<GetCityViewModel> GetSingleCity(Guid cityId)
        {
            var city = await _mediator.Send(new SingleCityQuery(cityId));
            var cityViewModel = _mapper.Map<GetCityViewModel>(city);
            return cityViewModel;
        }
    }
}
