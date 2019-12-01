using AutoMapper;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Stores;
using Group15.EventManager.Domain.Commands.Store;
using Group15.EventManager.Domain.Models;
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
    }
}
