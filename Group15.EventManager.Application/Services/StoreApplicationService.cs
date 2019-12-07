using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Stores;
using Group15.EventManager.Domain.Commands.Store;
using Group15.EventManager.Domain.Models;
using Group15.EventManager.Domain.Queries.Stores;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Services
{
    public class StoreApplicationService : Service, IStoreApplicationService
    {
        public StoreApplicationService(IMapper mapper, IMediator mediator) : base(mapper, mediator)
        {
        }

        public async Task CreateStore(CreateStoreViewModel storeViewModel)
        {
            var store = _mapper.Map<Store>(storeViewModel);
            await _mediator.Send(new CreateStoreCommand(store.Name, store.Address, store.Region, store.City));
        }

        public async Task<IEnumerable<GetStoreListViewModel>> GetAllStores()
        {
            var stores = await _mediator.Send(new AllStroresQuery());
            var storeViewModels = _mapper.Map<IEnumerable<GetStoreListViewModel>>(stores);
            return storeViewModels;

        }

        public async Task<GetSingleStoreViewModel> GetSingleStore(Guid storeId)
        {
            var store = await _mediator.Send(new SingleStoreQuery(storeId));
            var storeViewModel = _mapper.Map<GetSingleStoreViewModel>(store);
            return storeViewModel;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
