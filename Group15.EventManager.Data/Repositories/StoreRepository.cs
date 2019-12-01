using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Data.Repositories
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(SqlContext context) : base(context)
        {
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
