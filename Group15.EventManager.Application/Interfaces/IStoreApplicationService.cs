﻿using Group15.EventManager.ApplicationLayer.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Group15.EventManager.ApplicationLayer.Interfaces
{
    public interface IStoreApplicationService : IDisposable
    {
        Task<IEnumerable<GetStoreListViewModel>> GetAllStores();
        Task<GetSingleStoreViewModel> GetSingleStore(Guid storeId);
        Task CreateStore(CreateStoreViewModel storeViewModel);
    }
}
