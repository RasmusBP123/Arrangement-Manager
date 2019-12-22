using Group15.EventManager.Data.Context;
using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Group15.EventManager.Data.Repositories
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(SqlContext context) : base(context)
        { }

        public override IQueryable<Region> GetAll()
        {
            var regions = Db.Set<Region>().Include(region => region.Cities).Include(region => region.Events);
            return regions;
        }

        public override Region GetById(Guid id)
        {
            var region = Db.Set<Region>().Include(region => region.Cities)
                                         .Include(region => region.Events)
                                         .FirstOrDefault(region => region.Id == id);
            return region;
        }
    }
}
