using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Handlers;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Regions;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.QueryHandlers
{
    public class RegionQueryHandler : Handler,
                                      IRequestHandler<AllRegionsQuery, IQueryable<Region>>,
                                      IRequestHandler<SingleRegionQuery, Region>
    {
        private readonly IRegionRepository _regionRepository;

        public RegionQueryHandler(IMediator mediator, IUnitOfWork unitOfWork, IRegionRepository regionRepository) : base(mediator, unitOfWork)
        {
            _regionRepository = regionRepository;
        }

        public Task<IQueryable<Region>> Handle(AllRegionsQuery request, CancellationToken cancellationToken)
        {
            var regions = _regionRepository.GetAll();
            return Task.FromResult(regions);
        }

        public Task<Region> Handle(SingleRegionQuery request, CancellationToken cancellationToken)
        {
            var region = _regionRepository.GetById(request.RegionId);
            return Task.FromResult(region);
        }
    }
}
