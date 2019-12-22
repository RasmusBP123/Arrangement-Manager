using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Regions;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.QueryHandlers
{
    public class RegionQueryHandler : IRequestHandler<AllRegionsQuery, IQueryable<Region>>,
                                      IRequestHandler<SingleRegionQuery, Region>
    {
        private readonly IRegionRepository _regionRepository;

        public RegionQueryHandler(IRegionRepository regionRepository)
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
