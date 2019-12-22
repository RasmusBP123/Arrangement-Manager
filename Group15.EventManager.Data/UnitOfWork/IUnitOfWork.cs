using System;

namespace Group15.EventManager.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
