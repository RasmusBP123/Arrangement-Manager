using Group15.EventManager.Data.Context;
using Group15.EventManager.Domain.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Group15.EventManager.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SqlContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(SqlContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            Db.Add(entity);
        }

        public virtual TEntity GetById(Guid id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public virtual void Remove(Guid id)
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
