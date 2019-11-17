using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
