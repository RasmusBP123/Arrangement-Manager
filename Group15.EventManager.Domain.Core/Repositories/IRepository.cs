using System;
using System.Linq;

namespace Group15.EventManager.Domain.Core.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(Guid id);
        int SaveChanges();
    }
}
