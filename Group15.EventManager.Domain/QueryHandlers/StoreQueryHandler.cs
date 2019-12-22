using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Stores;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.QueryHandlers
{
    public class StoreQueryHandler : IRequestHandler<AllStroresQuery, IQueryable<Store>>
                                    , IRequestHandler<SingleStoreQuery, Store>
    {
        private readonly IStoreRepository _storeRepository;

        public StoreQueryHandler(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public Task<IQueryable<Store>> Handle(AllStroresQuery request, CancellationToken cancellationToken)
        {
            var stores = _storeRepository.GetAll();
            return Task.FromResult(stores);
        }

        public Task<Store> Handle(SingleStoreQuery request, CancellationToken cancellationToken)
        {
            var store = _storeRepository.GetById(request.Id);
            return Task.FromResult(store);
        }
    }
}
