using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group15.EventManager.Data.Repositories
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(SqlContext context) : base(context)
        {
        }

        public override IQueryable<Store> GetAll()
        {
            var stores = Db.Set<Store>().Include(store => store.Address)
                                        .Include(store => store.City)
                                        .Include(store => store.Region);
            return stores;
        }

        public override Store GetById(Guid id)
        {
            var store = Db.Set<Store>().Include(store => store.Address)
                                        .Include(store => store.City)
                                        .Include(store => store.Region)
                                        .Include(store => store.Employees).FirstOrDefault(store => store.Id == id);
            return store;
        }

        public override void Add(Store entity)
        {
            Db.Attach(entity.City);
            Db.Attach(entity.Region);
            Db.Set<Address>().Add(entity.Address);
            base.Add(entity);
        }
    }
}
