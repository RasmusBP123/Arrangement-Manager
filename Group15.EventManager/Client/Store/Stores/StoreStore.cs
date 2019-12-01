using Group15.EventManager.Shared.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group15.EventManager.Client.Store.Stores
{
    public class StoreStore
    {
        public IEnumerable<GetStoreListViewModel> Stores { get; set; } = new List<GetStoreListViewModel>();
    }
}
