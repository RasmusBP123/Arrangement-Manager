using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests.Entities
{
    [TestFixture]
    public class StoreEntity
    {
        private readonly SqlContext _context;
        private readonly IStoreRepository _storeRepository;

        public StoreEntity(SqlContext context, IStoreRepository storeRepository)
        {
            _context = context;
            _storeRepository = storeRepository;
            IQueryable<Store> Stores = new List<Store>
                {
                    new Store
                    {
                        Id = new Guid("260a6e7e-f16c-43f5-8a03-c4243e42c9bf"),
                        Name = "Slagelse vin",
                    },
                    new Store
                    {
                        Id = new Guid("e90fb831-798d-47a8-afa1-f3eb18b891fa"),
                        Name = "Skjern Vin"
                    }
                }.AsQueryable();
        }

        [Test]
        public void IsStoreFound()
        {
            var store = _storeRepository.GetById(new Guid("260a6e7e-f16c-43f5-8a03-c4243e42c9bf"));
            Assert.AreEqual("260a6e7e-f16c-43f5-8a03-c4243e42c9bf", store.Id);
        }
    }
}
