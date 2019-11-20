using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Regions;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Queries.Regions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class RegionApplicationService : Service, IRegionApplicationService
    {
        public RegionApplicationService(IUnitOfWork unitOfWork, IMapper mapper, IMediator mediator) : base(unitOfWork, mapper, mediator)
        {
        }

        public async Task<IEnumerable<GetRegionViewModel>> GetAllRegions()
        {
            var regions = await _mediator.Send(new AllRegionsQuery());
            var regionViewModels = _mapper.Map<IEnumerable<GetRegionViewModel>>(regions);
            return regionViewModels;
        }

        public async Task<GetRegionViewModel> GetSingleRegion(Guid regionId)
        {
            var region = await _mediator.Send(new SingleRegionQuery(regionId));
            var regionViewModel = _mapper.Map<GetRegionViewModel>(region);
            return regionViewModel;
        }
    }
}
