using Group15.EventManager.Data.Context;
using Group15.EventManager.Domain.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group15.EventManager.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(SqlContext sqlContext)
        {
            Db = sqlContext;
            DbSet = Db.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            Db.Add(entity);
        }

        public TEntity GetById(Guid id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public async Task<IQueryable<TEntity>> GetAll()
        {
            return DbSet;
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public void Remove(Guid id)
        {
            var entity = DbSet.Find(id);
            DbSet.Remove(entity);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
