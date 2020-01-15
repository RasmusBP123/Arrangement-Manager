using Group15.EventManager.Shared.Stores;
using System;
using System.Collections.Generic;

namespace Group15.EventManager.Client.Store.Stores
{
    public class StoreStore
    {
        public IEnumerable<GetStoreListViewModel> Stores { get; set; } = new List<GetStoreListViewModel>();
        public GetSingleStoreViewModel Store { get; set; } = new GetSingleStoreViewModel();
        public Guid Id; //Stores the id when creating an event.. Im a bit lazy
    }
}
